using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    internal class Team
    {
        // team name property
        public string Name 
        { 
            get; 
            set; 
        }
        // list of players
        public List<Player> Players
        {
            get;
            set;
        }

        // contructor to make a team and list the players in a team
        public Team ()
        {
            Players = new List<Player> ();
        }

        
        //overrides the default string
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
