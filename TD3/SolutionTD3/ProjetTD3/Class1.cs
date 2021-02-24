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
        string country_code;
        public string[] Cities { get => cities; set => cities = value; }
        public string Commercial_name { get => commercial_name; set => commercial_name = value; }
        public string Name { get => name; set => name = value; }
        public string Country_code { get => country_code; set => country_code = value; }

        public override string ToString()
        {
            string texte = "Name : " + name + "\n";
            if (commercial_name != null) texte += "Commercial Name : " + commercial_name + "\n";
            if (cities != null)
            {
                texte += "Cities : \n";
                for (int i = 0; i < Cities.Length; i++)
                {
                    texte += "   " + Cities[i] + "\n";
                }
            }
            if (country_code != null) texte += "Coutry Code : " + country_code + "\n";
            return texte; 
        }
    }
}
