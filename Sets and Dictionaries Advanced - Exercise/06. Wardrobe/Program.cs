using System;
using System.Collections.Generic;


Dictionary<string,Dictionary<string,int>> clothes = new Dictionary<string,Dictionary<string,int>>();


int n = int.Parse(Console.ReadLine());

string[] spearator = { "->", "," };
for (int i = 0; i < n; i++)
{
    string[] tokens = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

    string color = tokens[0];

    if (!clothes.ContainsKey(color))
    {
        clothes[color] = new Dictionary<string,int>();
    }

    for (int k = 1; k < tokens.Length; k++)
    {
        string currentCloth = tokens[k];

        if (!clothes[color].ContainsKey(currentCloth))
        {
            clothes[color].Add(currentCloth, 0);
        }
        clothes[color][currentCloth]++;
    }
}

string[] desiredGarment = Console.ReadLine().Split(); //iskana dreha

foreach (var color in clothes)
{
    Console.WriteLine($"{color.Key} clothes:");
    
    foreach (var item in color.Value)
    {
        string printItem = $"* {item.Key} - {item.Value}";

        if (color.Key == desiredGarment[0] && item.Key == desiredGarment[1] )
        {
            printItem += " (found!)";
        }
        Console.WriteLine(printItem);
    }
    
}