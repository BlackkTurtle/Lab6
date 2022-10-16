using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rebels = new List<Rebel>();
            var citizens=new List<Citizen>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input.Length == 4)
                {
                    Citizen citizen = new Citizen(input);
                    citizens.Add(citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(input);
                    rebels.Add(rebel);
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                int a = 0;
                for (int i = 0; i < rebels.Count; i++)
                {
                    if(rebels[i].Name == input)
                    {
                        rebels[i].BuyFood();
                        a = 1;
                        break;
                    }
                }
                if (a== 0)
                {
                    for (int i = 0; i < citizens.Count; i++)
                    {
                        if (citizens[i].Name == input)
                        {
                            citizens[i].BuyFood();
                            break;
                        }
                    }
                }
            }
            int result = 0;
            for (int i = 0; i < rebels.Count; i++)
            {
                result += rebels[i].Food;
            }
            for (int i = 0; i < citizens.Count; i++)
            {
                result += citizens[i].Food;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
