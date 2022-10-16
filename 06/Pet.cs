using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Pet:IPet
    {
        public Pet(string[] strarray)
        {
            Name = strarray[1];
            Birthday = strarray[2];
        }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public void CheckBirthday(string id,string lastdigits,ref int a)
        {
            string last3=id.Substring(id.Length-4);
            if (last3 == lastdigits)
            {
                Console.WriteLine(id);
                a++;
            }
        }
    }
}
