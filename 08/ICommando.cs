using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    interface ICommando:ISoldier
    {
        double Salary { get; set; }
        string Corp { get; set; }
        string[] Missions { get; set; }
        void Print(ICommando commando);
    }
}
