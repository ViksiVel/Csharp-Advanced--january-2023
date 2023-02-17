using System;
using System.Collections.Generic;

//Environment.NewLine -> поставя на нов ред
Action<string[]> print = strings => Console.WriteLine(string.Join(Environment.NewLine, strings));

string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

print(strings);