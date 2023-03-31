using System;
using System.Collections.Generic;

namespace SpeedRacing;

public class Startup
{
    static void Main(string[] args)
    {
        int numOfCar = int.Parse(Console.ReadLine());

        Dictionary<string, Car> carsByName = new();

        for (int i = 0; i < numOfCar; i++)
        {
            List<string> carProps = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

            Car car = new()
            {
                Model = carProps[0],
                FuelAmount = double.Parse(carProps[1]),
                FuelConsumptionPerKilometer = double.Parse(carProps[2])
            };

            carsByName.Add(car.Model, car);
        }

        string input = string.Empty;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string carModel = tokens[1];
            double amountOfKm = double.Parse(tokens[2]);

            Car car = carsByName[carModel];
            car.Drive(amountOfKm);
        }

        foreach (var car in carsByName.Values)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
        }


    }


}
