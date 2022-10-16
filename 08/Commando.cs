using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Commando:ICommando
    {
        public Commando(string[] strarray)
        {
            FirstName = strarray[2];
            LastName = strarray[3];
            Id = strarray[1];
            Salary = Convert.ToDouble(strarray[4]);
            Corp = strarray[5];
            Missions = CreateParts(strarray);
        }
        public string FirstName { get; set; }
        public string Id { get; set; }
        public string LastName { get; set; }
        public string Corp { get; set; }
        public double Salary { get; set; }
        private string[] missions;

        public string[] Missions
        {
            get { return missions; }
            set { missions = value; }
        }
        private string[] CreateParts(string[] strarray)
        {
            string[] result = new string[strarray.Length-6];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = strarray[i+6];
            }
            return result;
        }
        public void Print(ICommando commando)
        {
            Console.WriteLine("Name: {0} {1} Id: {2} Salary: {3}", commando.LastName, commando.FirstName, commando.Id, commando.Salary);
            Console.WriteLine("Corps: " + commando.Corp);
            if (commando.Missions != null)
            {
                Console.WriteLine("Missions:");
                for (int i = 0; i < commando.Missions.Length; i += 2)
                {
                    if (commando.Missions[i + 1] == "inProgress") 
                    {
                        Console.WriteLine("Code Name: {0} State: {1}", commando.Missions[i], commando.Missions[i + 1]);
                    }
                }
            }
        }
    }
}
