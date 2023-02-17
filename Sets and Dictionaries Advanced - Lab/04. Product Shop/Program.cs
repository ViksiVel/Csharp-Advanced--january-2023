using System;
using System.Linq;
using System.Collections.Generic;


Dictionary<string,Dictionary<string,double>> shops = new Dictionary<string,Dictionary<string,double>>();


string input = string.Empty;

while ((input = Console.ReadLine()) != "Revision") 
{
    string[] tokens = input.Split(", ",StringSplitOptions.RemoveEmptyEntries);

    string shop = tokens[0];
    string product = tokens[1];
    double price = double.Parse(tokens[2]);

    if (!shops.ContainsKey(shop))
    {
        shops.Add(shop, new Dictionary<string, double>());
    }
    if (!shops[shop].ContainsKey(product))
    {
        shops[shop].Add(product,0);
    }

    shops[shop][product] = price;

}

shops = shops.OrderBy(shop => shop.Key).ToDictionary(shop => shop.Key, shop => shop.Value);

foreach (var shop in shops) 
{
    Console.WriteLine($"{shop.Key}->");
    foreach (var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}