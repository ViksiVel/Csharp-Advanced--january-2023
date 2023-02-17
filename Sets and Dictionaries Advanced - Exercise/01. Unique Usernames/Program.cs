using System;
using System.Collections.Generic;


int numOfRows = int.Parse(Console.ReadLine());

HashSet<string> names = new HashSet<string>();

for (int i = 0; i < numOfRows; i++)
{
    string input = Console.ReadLine();
    names.Add(input);
    //names.Add(Console.ReadLine());

}

foreach (var name in names)
{
    Console.WriteLine(name);
}