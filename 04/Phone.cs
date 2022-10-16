using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Phone : IPhoneNumber, IBrowsing
    {
        public Phone(string[] strarray1, string[] strarray2)
        {
            Numbers = strarray1;
            Link = strarray2;
        }
        private string[] link;
        public string[] Link {
            get { return link; }
            set { link = value; }
        }
        private string[] numbers;
        public string[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }
        public void Browse(string[] strarray)
        {
            for (int i = 0; i < strarray.Length; i++)
            {
                if (strarray[i].Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    Console.WriteLine("Browsing: "+strarray[i]);
                }
            }
        }

        public void CallNumber(string[]strarray)
        {
            for (int i = 0; i < strarray.Length; i++) 
            {
                if (strarray[i].All(char.IsDigit))
                {
                    Console.WriteLine("Calling... " + strarray[i]);
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
