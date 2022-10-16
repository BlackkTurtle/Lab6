using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Citizen:IHuman,IRobot
    {
        public Citizen(string[] strarray)
        {
            Name = strarray[0];
            Age = strarray[1];
            HumanId = MakeHumanID(strarray);
            Model = strarray[0];
            RobotId = strarray[1];
        }
        private string MakeHumanID(string[] strarray)
        {
            if (strarray.Length == 3)
            {
                return strarray[2];
            }
            else { return strarray[1]; }
        }
        public string Name { get; set; }
        public string Model { get; set; }
        public string HumanId { get; set; }
        public string RobotId { get; set; }
        public string Age { get; set; }
        public void CheckID(string id,string lastdigits)
        {
            string last3=id.Substring(id.Length-3);
            if (last3 == lastdigits)
            {
                Console.WriteLine(id);
            }
        }
    }
}
