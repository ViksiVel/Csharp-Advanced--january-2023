using System;
using System.Collections.Generic;
using System.Linq;

int[] inputs = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int n = inputs[0];
int m = inputs[1];

HashSet<int> first = new HashSet<int>();
HashSet<int> second = new HashSet<int>();

for (int i = 0; i < n; i++)
{
   first.Add(int.Parse(Console.ReadLine()));


}
for (int i = 0; i < m; i++)
{
    second.Add(int.Parse(Console.ReadLine()));
}

first.IntersectWith(second);

Console.WriteLine(string.Join(" ",first));