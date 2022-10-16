using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    interface IPet
    {
        string Name { get; set; }
        string Birthday { get; set; }
        void CheckBirthday(string id,string lastdigits,ref int a);
    }
}
