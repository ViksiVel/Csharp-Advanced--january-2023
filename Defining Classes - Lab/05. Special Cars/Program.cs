using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<List<double>> listTiresYears = new List<List<double>>();
            List<List<double>> listTiresPressure = new List<List<double>>();
            List<int> listHorsePowers = new List<int>();
            List<double> listCubicCapacity = new List<double>();


            List<Car> listCars = new List<Car>();

            string input = string.Empty;

            Tires tires = new Tires();
            Engine engine = new Engine();

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                List<double> listYears = tires.GetYearInfo(tokens);
                List<double> listPressures = tires.GetPressureInfo(tokens);

                listTiresYears.Add(listYears);
                listTiresPressure.Add(listPressures);

            }

            string secondInput = string.Empty;

            while ((secondInput = Console.ReadLine()) != "Engines done")
            {
                string[] tokens = secondInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                listHorsePowers.Add(engine.GetHorsePower(tokens));
                listCubicCapacity.Add(engine.GetCubicCapacity(tokens));

            }

            string thirdInput = string.Empty;

            while ((thirdInput = Console.ReadLine()) != "Show special")
            {
                string[] tokens = thirdInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tiresIndex = int.Parse(tokens[6]);

                int horsePower = listHorsePowers[engineIndex];
                double pressure = tires.GetSumPressure(listTiresPressure, tiresIndex);

                Car car = new Car(make, model, year, horsePower, fuelQuantity, fuelConsumption, engineIndex, tiresIndex, pressure);

                listCars.Add(car);



            }

            foreach (var car in listCars)
            {
                if (car.Year >= 2017 && car.HorsePower > 330 && car.TotalPressure > 9 && car.TotalPressure < 10)
                {
                    car.FuelQuantity = car.Drive20Kilometers(car.FuelQuantity, car.FuelConsumption);

                    Console.WriteLine($"Make: {car.Make}");

                    Console.WriteLine($"Model: {car.Model}");

                    Console.WriteLine($"Year: {car.Year}");

                    Console.WriteLine($"HorsePowers: {car.HorsePower}");

                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }
            }
        }
    }
}
