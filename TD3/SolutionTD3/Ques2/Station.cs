using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques2
{
    class Station
    {
        int number;
        string contractName;
        string name;
        string address;
        int[] position;
        bool banking;
        bool bonus;
        string status;
        string lastUpdate;
        bool connected;
        bool overflow;
        string shape;
        Couple totalStands;
        Couple mainStands;
        Couple overflowStands;

        public int Number { get => number; set => number = value; }
        public string ContractName { get => contractName; set => contractName = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int[] Position { get => position; set => position = value; }
        public bool Banking { get => banking; set => banking = value; }
        public bool Bonus { get => bonus; set => bonus = value; }
        public string Status { get => status; set => status = value; }
        public string LastUpdate { get => lastUpdate; set => lastUpdate = value; }
        public bool Connected { get => connected; set => connected = value; }
        public bool Overflow { get => overflow; set => overflow = value; }
        public string Shape { get => shape; set => shape = value; }
        internal Couple TotalStands { get => totalStands; set => totalStands = value; }
        internal Couple MainStands { get => mainStands; set => mainStands = value; }
        internal Couple OverflowStands { get => overflowStands; set => overflowStands = value; }
    }

    class Couple
    {
        int[] availabilities;
        int capacity;

        public int[] Availabilities { get => availabilities; set => availabilities = value; }
        public int Capacity { get => capacity; set => capacity = value; }
    }

    
}
