using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGolfersProblem
{
    public class GolfScheduler
    {
        private int numPlayers;       
        private int groupSize;       
        private int numGroups;      
        private List<List<List<int>>> schedule; 
        private HashSet<(int, int)> playedTogether;
        private Random rand;
        DateTime starttime;

        public GolfScheduler(int numPlayers, int groupSize)
        {
            this.numPlayers = numPlayers;
            this.groupSize = groupSize;
            this.numGroups = numPlayers / groupSize;
            this.schedule = new List<List<List<int>>>();
            this.playedTogether = new HashSet<(int, int)>();
            this.rand = new Random();
        }

        public int CreateMaxSchedule(int depthLimit)
        {
            int weeks = 0;

            while (true)
            {
                var weekGroups = new List<List<int>>();
                for (int i = 0; i < numGroups; i++)
                    weekGroups.Add(new List<int>());

                var availablePlayers = new List<int>();
                for (int i = 0; i < numPlayers; i++)
                    availablePlayers.Add(i);

                int n = availablePlayers.Count;
              
                for (int i = availablePlayers.Count - 1; i > 0; i--)
                {
                    int j = rand.Next(i + 1);
                    (availablePlayers[i], availablePlayers[j]) = (availablePlayers[j], availablePlayers[i]);
                }

                Console.WriteLine($"Attempting to schedule week {weeks + 1}...");

                if (!ScheduleWeek(weekGroups, availablePlayers, depthLimit))
                {
                    Console.WriteLine($"No more valid weeks can be scheduled after {weeks} weeks.");
                    break; 
                }

                schedule.Add(weekGroups);
                weeks++;

                Console.WriteLine($"Week {weeks} Schedule:");
                for (int i = 0; i < weekGroups.Count; i++)
                {
                    Console.WriteLine($"  Group {i + 1}: {string.Join(", ", weekGroups[i])}");
                }
            }

            return weeks;
        }

        private bool ScheduleWeek(List<List<int>> weekGroups, List<int> availablePlayers, int depthLimit)
        {
            this.starttime = DateTime.UtcNow;
            return ScheduleGroup(0, new List<int>(availablePlayers), weekGroups, depthLimit, 0);
        }

        private bool ScheduleGroup(int groupIndex, List<int> availablePlayers, List<List<int>> weekGroups, int depthLimit, int currentDepth)
        {
            if (groupIndex == numGroups)
                return true;  

            if (currentDepth >= depthLimit)
                return false; 

            if ((DateTime.UtcNow - this.starttime).TotalHours > 24)
            {
                return false; 
            }

       
            var sortedPlayers = availablePlayers.OrderBy(player => playedTogether.Count(pair => pair.Item1 == player || pair.Item2 == player)).ToList();

            return TryPlayers(sortedPlayers, new List<int>(), groupSize, group =>
            {
                if (IsValidGroup(group))
                {
                    weekGroups[groupIndex] = group;
                    MarkPairs(group);

                    var remainingPlayers = new List<int>(availablePlayers);
                    foreach (var player in group)
                    {
                        remainingPlayers.Remove(player);  
                    }

                    if (ScheduleGroup(groupIndex + 1, remainingPlayers, weekGroups, depthLimit, currentDepth + 1))
                        return true;

                    UnmarkPairs(group);
                }
                return false;
            });
        }


        private bool TryPlayers(List<int> players, List<int> currentGroup, int remaining, Func<List<int>, bool> callback)
        {
            if (remaining == 0)
                return callback(currentGroup);

            for (int i = 0; i < players.Count; i++)
            {
                int player = players[i];
                players.RemoveAt(i);
                currentGroup.Add(player);

                if (TryPlayers(players, currentGroup, remaining - 1, callback))
                    return true;

                currentGroup.RemoveAt(currentGroup.Count - 1);
                players.Insert(i, player); 
            }
            return false;
        }

        private bool IsValidGroup(List<int> group)
        {
            for (int i = 0; i < group.Count; i++)
            {
                for (int j = i + 1; j < group.Count; j++)
                {
                    if (playedTogether.Contains((Math.Min(group[i], group[j]), Math.Max(group[i], group[j]))))
                        return false;
                }
            }
            return true;
        }

        private void MarkPairs(List<int> group)
        {
            for (int i = 0; i < group.Count; i++)
            {
                for (int j = i + 1; j < group.Count; j++)
                {
                    playedTogether.Add((Math.Min(group[i], group[j]), Math.Max(group[i], group[j])));
                }
            }
        }

        private void UnmarkPairs(List<int> group)
        {
            for (int i = 0; i < group.Count; i++)
            {
                for (int j = i + 1; j < group.Count; j++)
                {
                    playedTogether.Remove((Math.Min(group[i], group[j]), Math.Max(group[i], group[j])));
                }
            }
        }

        public void PrintSchedule()
        {
            for (int week = 0; week < schedule.Count; week++)
            {
                Console.WriteLine($"Week {week + 1}:");
                for (int group = 0; group < schedule[week].Count; group++)
                {
                    Console.WriteLine($"  Group {group + 1}: {string.Join(", ", schedule[week][group])}");
                }
            }
        }

    }
}
