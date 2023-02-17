using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());

Dictionary<int, int> numbers = new();

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (!numbers.ContainsKey(num))
    {
        numbers.Add(num, 0);
    }
    numbers[num]++;
}
//Single() -> Връща единствения елемент от колекция или единствения елемент, който отговаря на условие. Ако Single() не намери елементи или повече от един елемент в колекцията, тогава хвърля InvalidOperationException.

Console.WriteLine(numbers.Single(n => n.Value % 2 == 0).Key);
