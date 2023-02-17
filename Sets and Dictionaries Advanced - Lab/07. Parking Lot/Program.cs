using System;
using System.Collections.Generic;


string input = string.Empty;

HashSet<string> cars = new HashSet<string>();

while ((input = Console.ReadLine()) != "END")
{
    string[] tokens = input.Split(", ",StringSplitOptions.RemoveEmptyEntries);

    if (tokens[0] == "IN")
    {
        cars.Add(tokens[1]);
    }
    else if (tokens[0] == "OUT")
    {
        if (!cars.Contains(tokens[1]))
        {
            continue;
        }

        cars.Remove(tokens[1]);
    }
}
if (cars.Count > 0)
{
    foreach (var car in cars)
    {
        Console.WriteLine(car);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}
