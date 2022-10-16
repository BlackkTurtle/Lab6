using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Citizen : IPerson,IIdentifiable,IBirthable
    {
        public Citizen(string name,int age,string id,string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
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
        private string _id;
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        private string _birthdate;
        public string Birthdate
        {
            get
            {
                return _birthdate;
            }
            set
            {
                _birthdate=value;
            }
        }
    }
}
