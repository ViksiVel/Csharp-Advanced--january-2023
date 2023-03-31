using System;
using System.Collections.Generic;

namespace SpeedRacing2;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, Car> carsName = new Dictionary<string, Car>();
      
        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Car car = new Car()
            {
                Model = tokens[0],
                FuelAmount = double.Parse(tokens[1]),
                FuelConsumptionPerKilometer = double.Parse(tokens[2])
            };

            carsName.Add(car.Model, car);
            
        }

        string input = string.Empty;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string carName = tokens[1];
            double amountOfKm = double.Parse(tokens[2]);

            Car car = carsName[carName];

            car.Drive(amountOfKm);

        }


        foreach (var car in carsName.Values)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelDistance}");
        }







    }



}