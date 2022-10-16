using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class LeutenantGeneral:ILeutenantGeneral
    {
        public LeutenantGeneral(string[] strarray)
        {
            FirstName = strarray[2];
            LastName = strarray[3];
            Id = strarray[1];
            Salary = Convert.ToDouble(strarray[4]);
            PrivateID = CreatePrivateID(strarray);
        }
        public string FirstName { get; set; }
        public string Id { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        private string[] privateid;

        public string[] PrivateID
        {
            get { return privateid; }
            set { privateid = value; }
        }
        private string[] CreatePrivateID(string[] strarray)
        {
            string[] result = new string[strarray.Length-5];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = strarray[i+5];
            }
            return result;
        }
        public void Print(ILeutenantGeneral leutenantGeneral,List<IPrivate> privates)
        {
            Console.WriteLine("Name: {0} {1} Id: {2} Salary: {3}", leutenantGeneral.LastName, leutenantGeneral.FirstName, leutenantGeneral.Id, leutenantGeneral.Salary);
            Console.WriteLine("Privates:");
            for (int i = 0; i < privates.Count; i++)
            {
                IPrivate priv = privates[i];
                for (int j = 0; j < leutenantGeneral.PrivateID.Length; j++) 
                {
                    if (priv.Id == leutenantGeneral.PrivateID[j])
                    {
                        priv.Print(priv);
                    }
                }
            }
        }
    }
}
