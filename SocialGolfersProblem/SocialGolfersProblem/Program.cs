using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGolfersProblem
{
    public class Program
    {

        static void Main(string[] args)
        {
            int numPlayers = 32;   
            int groupSize = 4;     
            int depthLimit = 10;   

            var scheduler = new GolfScheduler(numPlayers, groupSize);
            int maxWeeks = scheduler.CreateMaxSchedule(depthLimit); 

            Console.WriteLine($"Maximum weeks scheduled: {maxWeeks}");
            scheduler.PrintSchedule();
        }

    }
}
