using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }


        

        public override string ToString()
        {
            string weight = Weight == 0 ? "n/a" : Weight.ToString(); //  Ako kilogramite sa ravni na 0, vzima se defoltna stoinost, koqto se prevrushta v string - "n/v", a ako ima vzima stoinstta, primer: 1300 

            string color = Color ?? "n/a"; // Ako cveta e null tokaga stringa priema stoinost "n/a", a ako ima stoinost promenlivata s cvqt, primer: "Silver" 

            string result =
           $"{Model}:{Environment.NewLine}" +
           $"  {Engine.ToString()}{Environment.NewLine}" +
           $"  Weight: {weight}{Environment.NewLine}" +
           $"  Color: {color}";

            return result;
        }

    }
}
