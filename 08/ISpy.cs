using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    interface ISpy:ISoldier
    {
        string CodeNumber { get; set; }
        void Print(ISpy spy);
    }
}
