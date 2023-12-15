using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    internal class Team : IComparable
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
        // teams total points
        public int Points
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
            return $"{Name} {Points}";
        }

        public int CompareTo(object obj)
        {
            Team that = obj as Team;
            if (this.Points > that.Points)
            {
                return -1;
            }
            else if (this.Points < that.Points)
            {
                return 1;
            }
            else
            {
                return this.Points.CompareTo(that.Points);
            }
        }
    }
}
