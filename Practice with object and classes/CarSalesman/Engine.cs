using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }



        public string Model { get; set; }
        public int Power { get; set; }

        public int Displacement { get; set; }
        public string Efficiency { get; set; }



        public override string ToString()
        {
            string displacement = Displacement == 0 ? "n/a" : Displacement.ToString(); //  Ako displacement e ravno na 0, vzima se defoltna stoinost, koqto se prevrushta v string - "n/v", a ako ima vzima stoinstta

            string efficiency = Efficiency ?? "n/a"; // Ako cveta e null tokaga stringa priema stoinost "n/a", a ako ima stoinost promenlivata s cvqt, primer: "Silver" 
            string result =
            $"{Model}:{Environment.NewLine}" +
            $"    Power: {Power}{Environment.NewLine}" +
            $"    Displacement: {displacement}{Environment.NewLine}" +
            $"    Efficiency: {efficiency}";

            return result;
        }




    }
}
