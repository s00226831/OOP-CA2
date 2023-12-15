using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    internal class Player
    {
        // name property 
        public string Name
        {
            get; 
            set;
        }
        // property to record results
        public string ResultRecords
        {
            get;
            set;
        }
        // players points
        public int Points
        {
            get;
            set;
        }
        //overrides the default string
        public override string ToString()
        {
            return $"{Name} {ResultRecords} {Points}";
        }

        public int CalculatePoints()
        {
            foreach (char result in ResultRecords)
            {
                if (result == 'W')
                {
                    Points += 3; 
                }
                else if (result == 'D')
                {
                    Points += 1; 
                }  
            }
            return Points;
        }
    }
}
