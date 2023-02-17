using System;
using System.Collections.Generic;
using System.Linq;

List<int> numbers = new List<int>(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

Console.WriteLine(numbers.Count);
Console.WriteLine(numbers.Sum());