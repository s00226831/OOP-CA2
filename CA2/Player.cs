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

        // contructor to create a player
        public Player(string name, string resultRecords)
        {
            Name = name;
            ResultRecords = resultRecords;
        }
    }
}
