using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    interface IHuman
    {
        string Name { get; set; }
        string Age { get; set; }
        string HumanId { get; set; }
        void CheckID(string id,string lastdigits);
    }
}
