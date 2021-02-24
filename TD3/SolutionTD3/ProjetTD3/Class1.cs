using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetTD3
{
    class Contract
    {
        string name;

        string commercial_name;
        string [] cities;

        public string[] Cities { get => cities; set => cities = value; }
        public string Commercial_name { get => commercial_name; set => commercial_name = value; }
        public string Name { get => name; set => name = value; }
    }
}
