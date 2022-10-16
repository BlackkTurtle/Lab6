using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Spy:ISpy
    {
        public Spy(string[] strarray)
        {
            FirstName = strarray[2];
            LastName = strarray[3];
            Id = strarray[1];
            CodeNumber = strarray[4];
        }
        public string FirstName { get; set; }
        public string Id { get; set; }
        public string LastName { get; set; }
        public string CodeNumber { get; set; }
        public void Print(ISpy spy)
        {
            Console.WriteLine("Name: {0} {1} Id: {2}", spy.LastName, spy.FirstName, spy.Id);
            Console.WriteLine("Code Number: "+spy.CodeNumber);
        }
    }
}
