using System;
using System.Collections.Generic;

namespace SpeedRacing;

public class Startup
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string,Car> carsByName = new Dictionary<string,Car>();

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Car car = new Car()
            {
                Model = tokens[0],
                FuelAmount = double.Parse(tokens[1]),
                FuelConsumptionPerKilometer = double.Parse(tokens[2])
            };
            //dobavqme imeto/modela/ na kolata i celiq klas kola
            carsByName.Add(car.Model,car);

        }
        string input = string.Empty;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string carModel = tokens[1];
            double amountOfKm = double.Parse(tokens[2]);

            //tyk izvikvame suotvetniq model kola ot dictionary-to
            Car car = carsByName[carModel];

            //tyk prilagame metoda ot clasa Car
            car.Drive(amountOfKm);

        }

        foreach (var car in carsByName.Values)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
        }




    }
}
