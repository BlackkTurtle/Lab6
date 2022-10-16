using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Citizen : IPerson
    {
        public Citizen(string name,int age)
        {
            Name = name;
            Age = age;
        }
        private string _name;
        public string Name { get
            {
                return _name; 
            }
            set
            {
                _name = value;
            } 
        }
        private int _age;
        public int Age { 
            get {
                return _age;
            } set
            {
                _age = value;
            }    
        }
    }
}
