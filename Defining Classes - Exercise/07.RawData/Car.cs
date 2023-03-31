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
        double pressure1,
        int age1,
        double pressure2,
        int age2,
        double pressure3,
        int age3,
        double pressure4,
        int age4)
        {
            Model = model;
            Engine = new(speed, power);
            Cargo = new(weight, type);
            Tires = new Tires[4];
            Tires[0] = new(age1, pressure1);
            Tires[1] = new(age2, pressure2);
            Tires[2] = new(age3, pressure3);
            Tires[3] = new(age4, pressure4);

        }


        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires[] Tires { get; set; }

    }
}
