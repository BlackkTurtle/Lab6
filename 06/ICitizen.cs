using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    interface ICitizen
    {
        string Name { get; set; }
        string Age { get; set; }
        string Id { get; set; }
        string Birthday { get; set; }
        void CheckBirthday(string birthday,string lastdigits,ref int a);
    }
}
