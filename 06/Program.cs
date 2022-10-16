using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var robots = new List<IRobot>();
            var humans = new List<ICitizen>();
            var pets = new List<IPet>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0]=="Pet")
                {
                    IPet ipet = new Pet(input);
                    pets.Add(ipet);
                }
                else if (input[0]=="Citizen")
                {
                    ICitizen ihuman = new Citizen(input);
                    humans.Add(ihuman);
                }else if (input[0] == "Robot")
                {
                    IRobot robot = new Robot(input);
                    robots.Add(robot);
                }
                else { break; }
            }
            string lastdigits = Console.ReadLine();
            int result = 0;
            foreach (IPet ppets in pets)
            {
                ppets.CheckBirthday(ppets.Birthday, lastdigits,ref result);
            }
            foreach (ICitizen human in humans)
            {
                human.CheckBirthday(human.Birthday, lastdigits,ref result);
            }
            if (result == 0)
            {
                Console.WriteLine("<empty output>");
            }
            Console.ReadLine();
        }
    }
}
