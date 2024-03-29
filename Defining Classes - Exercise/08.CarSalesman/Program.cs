﻿using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] engineProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = CreateEngine(engineProperties);

                engines.Add(engine);
            }
            int countCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < countCars; i++)
            {
                string[] carProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = CreateCar(carProperties, engines);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }

        }

        static Engine CreateEngine(string[] engineProperties)
        {
            Engine engine = new(engineProperties[0], int.Parse(engineProperties[1]));

            if (engineProperties.Length > 2)
            {
                int displacement;
                //here we check if we have a given value, because in the description it says we may have, we may not have, if we have, we will return a weight of the value
                bool isDigit = int.TryParse(engineProperties[2], out displacement);

                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = engineProperties[2];
                }
                if (engineProperties.Length > 3)
                {
                    engine.Efficiency = engineProperties[3];
                }
            }
            return engine;
        }

        static Car CreateCar(string[] carProperties,List<Engine> engines)
        {
            Engine engine = engines.Find(x => x.Model == carProperties[1]);
            Car car = new(carProperties[0], engine);

            if (carProperties.Length > 2)
            {
                int weight;
                //here we check if we have a given value, because in the description it says we may have, we may not have, if we have, we will return a weight of the value
                bool isDigit = int.TryParse(carProperties[2], out weight);

                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = carProperties[2];
                }
                if (carProperties.Length > 3)
                {
                    car.Color = carProperties[3];
                }
            }
            return car;
        }
    }
}