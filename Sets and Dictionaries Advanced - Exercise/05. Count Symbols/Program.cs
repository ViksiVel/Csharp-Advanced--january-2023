using System;
using System.Linq;
using System.Collections.Generic;

SortedDictionary<char, int> letters = new SortedDictionary<char, int>();

string input = Console.ReadLine();

char[] chars = input.ToCharArray();

foreach (var ch in chars)
{
    if (!letters.ContainsKey(ch))
    {
        letters.Add(ch, 0);
    }
    letters[ch]++;
}


foreach (var item in letters)
{
    Console.WriteLine($"{item.Key}: {item.Value} time/s");
}