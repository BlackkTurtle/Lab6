using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    interface ICar
    {
        string Model { get; }
        string Brakes();
        string GasPedal();
        string DriversName { get; set; }
    }
}
