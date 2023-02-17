using System;
using System.Collections.Generic;
using System.Linq;


double[] numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();


Dictionary<double, int> result = new Dictionary<double, int>();

foreach (var num in numbers)
{
    if (!result.ContainsKey(num))
    {
        result.Add(num, 0);

    }
    result[num]++;
}

foreach (var occ in result)
{
    Console.WriteLine($"{occ.Key} - {occ.Value} times");
}