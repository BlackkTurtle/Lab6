using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Citizen:IBuyer,IHuman
    {
        public Citizen(string[] strarray)
        {
            Name = strarray[0];
            Age = strarray[1];
            Id = strarray[2];
            Birthday = strarray[3];
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Age { get; set; }
        public string Birthday { get; set; }
        private int food = 0;

        public int Food
        {
            get { return food; }
        }
        public void BuyFood()
        {
            food += 10;
        }
    }
}
