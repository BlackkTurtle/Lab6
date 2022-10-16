using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Cache;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07
{
    class Rebel:IHuman,IBuyer
    {
        public Rebel(string[] strarray)
        {
            Name = strarray[0];
            Age = strarray[1];
            this.Group = strarray[2];
        }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Group { get; set; }
        private int food=0;

        public int Food
        {
            get { return food; }
        }
        public void BuyFood()
        {
            food += 5;
        }
    }
}
