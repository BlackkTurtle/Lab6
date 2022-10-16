using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    interface IRobot
    {
        string Model { get; set; }
        string RobotId { get; set; }
        void CheckID(string id,string lastdigits);
    }
}
