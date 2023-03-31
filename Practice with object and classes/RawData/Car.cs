using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        public Car(
            string model,
            int speed,
            int power,
            int weight,
            string type,
            double tirePressure1,
            int tireAge1,
            double tirePressure2,
            int tireAge2,
            double tirePressure3,
            int tireAge3,
            double tirePressure4,
            int tireAge4)
        {
            Model = model;
            Engine = new(speed, power);
            Cargo = new(weight, type);
            Tires = new Tire[4];
            Tires[0] = new(tireAge1,tirePressure1);
            Tires[1] = new(tireAge2,tirePressure2);
            Tires[2] = new(tireAge3,tirePressure3);
            Tires[3] = new(tireAge4,tirePressure4);
        }



        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }



    }
}
