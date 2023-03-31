using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        //конструктор?
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public string Model { get; set; }
        public int Displacement { get; set; }
        public int Power { get; set; }
        public string Efficiency { get; set; }


        public override string ToString()
        {
            string displacement = Displacement == 0 ? "n/a" : Displacement.ToString();
            string effiency = Efficiency ?? "n/a";

            string resut =
            $"{Model}:{Environment.NewLine}" +
            $"    Power: {Power}{Environment.NewLine}" +
            $"    Displacement: {displacement}{Environment.NewLine}" +
            $"    Efficiency: {effiency}";

            return resut;
        }



    }


}
