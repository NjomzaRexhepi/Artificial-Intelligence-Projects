using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGolfersProblem
{
    public class Week
    {
        public List<GroupOfPlayers> Groups { get; set; }
        
        public Week(int numGroups) {
            Groups = new List<GroupOfPlayers>(numGroups);

            for(int i = 0; i<numGroups; i++)
            {
                Groups.Add(new GroupOfPlayers());
            }
        }
    }
}
