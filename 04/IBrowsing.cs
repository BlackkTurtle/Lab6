using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    interface IBrowsing
    {
        string[] Link { get; set; }
        void Browse(string[]strarray);
    }
}
