using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Pets
    {
        public string type;
        public string name;
        public string owner;
        public double weight;

        public Pets(string type1, string name1, string owner1, double weight1)
        {
            type = type1;
            name = name1;
            owner = owner1;
            weight = weight1;
        }
        public string getTag()
        {
            string lost = "If lost, call " + owner;
            return lost;
        }


    }
}

