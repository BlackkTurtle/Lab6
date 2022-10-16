using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Ferrari : ICar
    {
        public Ferrari(string driversname)
        {
            DriversName = driversname;
        }
        private string model ="488-Spider";
        public string Model
        {
            get { return model; }
        }
        private string _driversname;
        public string DriversName { get
            {
                return _driversname;
            }
            set 
            { 
                _driversname = value;
            }
        }
        public string Brakes()
        {
            return "Brakes!";
        }

        public string GasPedal()
        {
            return "Zadu6avam sA!";
        }
    }
}
