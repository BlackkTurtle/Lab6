using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    interface IEngineer:ISoldier
    {
        double Salary { get; set; }
        string Corp { get; set; }
        string[] Parts { get; set; }
        void Print(IEngineer engineer);
    }
}
