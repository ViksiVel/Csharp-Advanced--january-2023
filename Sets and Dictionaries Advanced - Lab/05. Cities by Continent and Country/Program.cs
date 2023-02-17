using System;
using System.Linq;
using System.Collections.Generic;


Dictionary<string,Dictionary<string,List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();


int numOfRows = int.Parse(Console.ReadLine());


for (int i = 0; i < numOfRows; i++)
{
    string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string continent = tokens[0];
    string country = tokens[1];
    string city = tokens[2];

    if (!continents.ContainsKey(continent))
    {
        continents.Add(continent, new Dictionary<string, List<string>>());
    }
    if (!continents[continent].ContainsKey(country))
    {
        continents[continent].Add(country, new List<string>());
    }
    
    continents[continent][country].Add(city);
}

foreach (var continent in continents)
{
    Console.WriteLine($"{continent.Key}:");
    foreach (var v in continent.Value)
    {
        Console.WriteLine($"{v.Key} -> {string.Join(", ",v.Value)}");
    }
}
