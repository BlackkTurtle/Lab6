using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    interface IPrivate:ISoldier
    {
        double Salary { get; set; }
        void Print(IPrivate soldier);
    }
}
