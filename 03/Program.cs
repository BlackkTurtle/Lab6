using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string driversname=Console.ReadLine();
            ICar icar=new Ferrari(driversname);
            Console.WriteLine(icar.Model + "/" + icar.Brakes() + "/" + icar.GasPedal() + "/" + icar.DriversName);
            Console.ReadLine();
        }
    }
}
