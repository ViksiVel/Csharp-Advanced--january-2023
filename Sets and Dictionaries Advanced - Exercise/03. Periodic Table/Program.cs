using System;
using System.Collections.Generic;


int n = int.Parse(Console.ReadLine());

SortedSet<string> chemicalCompounds = new();

for (int i = 0; i < n; i++)
{
    string[] elements = Console.ReadLine().Split();

    chemicalCompounds.UnionWith(elements); //Модифицира текущия обект SortedSet<T>, така че да съдържа всички елементи, които присъстват или в текущия обект, или в указаната колекция.
}

Console.WriteLine(string.Join(" ",chemicalCompounds));