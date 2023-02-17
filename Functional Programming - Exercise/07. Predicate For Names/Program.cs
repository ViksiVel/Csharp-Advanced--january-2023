using System;
using System.Collections.Generic;

int lengOfWord = int.Parse(Console.ReadLine());

List<string> words = new List<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

Predicate<string> match = words => words.Length <= lengOfWord;



foreach (var word in words)
{
    if (match(word))
    {
        Console.WriteLine(word);
    }
}