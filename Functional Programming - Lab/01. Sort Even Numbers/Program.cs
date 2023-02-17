using System;
using System.Collections.Generic;
using System.Linq;

List<int> numbers = new List<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where((x) => x % 2 ==0).OrderBy(x => x).ToList());

Console.WriteLine(string.Join(", ",numbers));