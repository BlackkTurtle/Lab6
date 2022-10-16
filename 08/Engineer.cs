using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Engineer:IEngineer
    {
        public Engineer(string[] strarray)
        {
            FirstName = strarray[2];
            LastName = strarray[3];
            Id = strarray[1];
            Salary = Convert.ToDouble(strarray[4]);
            Corp = strarray[5];
            Parts = CreateParts(strarray);
        }
        public string FirstName { get; set; }
        public string Id { get; set; }
        public string LastName { get; set; }
        public string Corp { get; set; }
        public double Salary { get; set; }
        private string[] parts;

        public string[] Parts
        {
            get { return parts; }
            set { parts = value; }
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
        public void Print(IEngineer engineer)
        {
            Console.WriteLine("Name: {0} {1} Id: {2} Salary: {3}", engineer.LastName, engineer.FirstName, engineer.Id, engineer.Salary);
            Console.WriteLine("Corps: "+engineer.Corp);
            if (engineer.Parts != null)
            {
                Console.WriteLine("Repairs:");
                for (int i = 0; i < engineer.Parts.Length; i+=2)
                {
                    Console.WriteLine("Part Name: {0} Hours Worked: {1}", engineer.Parts[i], engineer.Parts[i+1]);
                }
            }
        }
    }
}
