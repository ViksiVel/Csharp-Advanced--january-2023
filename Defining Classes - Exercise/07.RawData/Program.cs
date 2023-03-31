using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData;

public class Startup
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Car> cars = new();
        //List<string> flammable = new List<string>();

        for (int i = 0; i < n; i++)
        {
            List<string> props = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

            Car car = new(
                props[0],
                int.Parse(props[1]),
                int.Parse(props[2]),
                int.Parse(props[3]),
                props[4],
                double.Parse(props[5]),
                int.Parse(props[6]),
                double.Parse(props[7]),
                int.Parse(props[8]),
                double.Parse(props[9]),
                int.Parse(props[10]),
                double.Parse(props[11]),
                int.Parse(props[12])
                );

            cars.Add(car);
        }
        string input = Console.ReadLine();

        List<string> filteredCarModels;

        if (input == "fragile" )
        {
            //from cars take where cargo type is "fragile" and any of tires have pressure less than 1 ant take model of car
            filteredCarModels = cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1)).Select(c => c.Model)
                .ToList();
        }
        else
        {
            //from cars take where cargo type is "flammable" and engine power more than 250
            filteredCarModels = cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250).Select(c => c.Model)
                .ToList();
        }
        //Environment.NewLine -> add new line
        Console.WriteLine(string.Join(Environment.NewLine,filteredCarModels));
    }
}