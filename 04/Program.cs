using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1=Console.ReadLine();
            string str2=Console.ReadLine();
            IPhoneNumber phoneNumber = new Phone(str1.Split(' ').ToArray(),str2.Split(' ').ToArray());
            IBrowsing browsing = new Phone(str1.Split(' ').ToArray(), str2.Split(' ').ToArray());   
            phoneNumber.CallNumber(phoneNumber.Numbers);     
            browsing.Browse(browsing.Link);
            Console.ReadLine();
        }
    }
}
