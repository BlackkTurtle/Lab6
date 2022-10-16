using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Private:IPrivate
    {
        public Private(string[] strarray)
        {
            FirstName = strarray[2];
            LastName = strarray[3];
            Id = strarray[1];
            Salary = Convert.ToDouble(strarray[4]);
        }
        public string FirstName { get; set; }
        public string Id { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public void Print(IPrivate soldier)
        {
            Console.WriteLine("Name: {0} {1} Id: {2} Salary: {3}",soldier.LastName,soldier.FirstName,soldier.Id,soldier.Salary);
        }
    }
}
