using System;
using System.Collections.Generic;
using System.Linq;

int length = int.Parse(Console.ReadLine());

List<int> divisors = new List<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList());

List<int> result = new List<int>();
Func<int, List<int>, List<int>> range = (length, divisors) =>
{
    
    for (int i = 0; i < length; i++)
    {
        result.Add(i);
    }


    return result;
};

Predicate<int> filter = number => number / divisors[0] == 0;

foreach (var num in result)
{
    if (filter(num))
    {
        Console.Write(num);
    }
}


