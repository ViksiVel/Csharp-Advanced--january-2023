using System;
using System.Collections.Generic;
using System.Linq;

Predicate<string> filterByUpperCase = x => x[0] == char.ToUpper(x[0]) && char.IsLetter(x[0]);

string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Where(x => filterByUpperCase(x)).ToArray();

foreach (var item in input)
{
    Console.WriteLine(item);
}
