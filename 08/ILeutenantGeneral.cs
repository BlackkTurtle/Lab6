using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    interface ILeutenantGeneral:ISoldier
    {
        double Salary { get; set; }
        string[] PrivateID { get; set; }
        void Print(ILeutenantGeneral leutenantGeneral,List<IPrivate> privates);
    }
}
