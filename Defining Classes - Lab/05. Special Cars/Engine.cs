using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Special_Cars
{
    internal class Engine
    {
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }


        public int GetHorsePower(string[] splitted)
        {
            int horsePower = int.Parse(splitted[0]);

            return horsePower;
        }

        public double GetCubicCapacity(string[] splitted)
        {
            double cubicCapacity = double.Parse(splitted[1]);

            return cubicCapacity;
        }
    }
}
