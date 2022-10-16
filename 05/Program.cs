using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var robots = new List<IRobot>();
            var humans=new List<IHuman>();
            while (true)
            {
                string[] input=Console.ReadLine().Split(' ');
                if (input.Length == 2)
                {
                    IRobot irobot = new Citizen(input);
                    robots.Add(irobot);
                }
                else if(input.Length == 3)
                {
                    IHuman ihuman = new Citizen(input);
                    humans.Add(ihuman);
                }
                else { break; }
            }
            string lastdigits=Console.ReadLine();
            foreach(IRobot irobot in robots)
            {
                irobot.CheckID(irobot.RobotId,lastdigits);
            }
            foreach(IHuman human in humans)
            {
                human.CheckID(human.HumanId, lastdigits);
            }
            Console.ReadLine();
        }
    }
}
