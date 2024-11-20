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

        public GolfScheduler(int numPlayers, int groupSize)
        {
            this.numPlayers = numPlayers;
            this.groupSize = groupSize;
            this.numGroups = numPlayers / groupSize;
            this.schedule = new List<List<List<int>>>();
            this.playedTogether = new HashSet<(int, int)>();
        }

        //public int CreateMaxSchedule()
        //{
        //    int weeks = 0;
        //    while (true)
        //    {
        //        var weekGroups = new List<List<int>>();
        //        for (int i = 0; i < numGroups; i++)
        //            weekGroups.Add(new List<int>());

        //        if (!ScheduleWeek(weekGroups))
        //            break; 

        //        schedule.Add(weekGroups);
        //        weeks++;
        //    }
        //    return weeks;
        //}
        public int CreateMaxSchedule()
        {
            int weeks = 0;
            bool foundNewSchedule;

            do
            {
                foundNewSchedule = false;
                var weekGroups = new List<List<int>>();
                for (int i = 0; i < numGroups; i++)
                    weekGroups.Add(new List<int>());

                if (ScheduleWeek(weekGroups))
                {
                    schedule.Add(weekGroups);
                    weeks++;
                    foundNewSchedule = true; 
                }
            }
            while (foundNewSchedule);

            return weeks;
        }
        private bool ScheduleWeek(List<List<int>> weekGroups)
        {
            var availablePlayers = new List<int>();
            for (int i = 0; i < numPlayers; i++)
                availablePlayers.Add(i);

            return ScheduleGroup(0, availablePlayers, weekGroups);
        }

        private bool ScheduleGroup(int groupIndex, List<int> availablePlayers, List<List<int>> weekGroups)
        {
            if (groupIndex == numGroups)
                return true; 

           
            return TryPlayers(availablePlayers, new List<int>(), groupSize, group =>
            {
                if (IsValidGroup(group))
                {
                    weekGroups[groupIndex] = group;
                    MarkPairs(group);

                    if (ScheduleGroup(groupIndex + 1, availablePlayers, weekGroups))
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
            foreach (var player1 in group)
            {
                foreach (var player2 in group)
                {
                    if (player1 >= player2)
                        continue;

                    if (playedTogether.Contains((player1, player2)))
                        return false;
                }
            }
            return true;
        }

        private void MarkPairs(List<int> group)
        {
            foreach (var player1 in group)
            {
                foreach (var player2 in group)
                {
                    if (player1 < player2)
                        playedTogether.Add((player1, player2));
                }
            }
        }

        private void UnmarkPairs(List<int> group)
        {
            foreach (var player1 in group)
            {
                foreach (var player2 in group)
                {
                    if (player1 < player2)
                        playedTogether.Remove((player1, player2));
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
