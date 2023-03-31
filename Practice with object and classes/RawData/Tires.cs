using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tire
    {
        public Tire(int tireAge, double pressure)
        {
            TireAge = tireAge;
            Pressure = pressure;
            
        }

        public int TireAge { get; set; }
        public double Pressure { get; set; }

    }
}
