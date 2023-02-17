using System;
using System.Collections.Generic;
using System.Linq;


Func<string, List<int>, List<int>> calculatee = (comмand, numbers) =>
{
    List<int> result = new();
    foreach (var number in numbers)
    {
        switch (comмand)
        {
            case "add":
                result.Add(number + 1);
                break;
            case "subtract":
                result.Add(number - 1);
                break;
            case "multiply":
                result.Add(number * 2);
                break;
        }
    }


    return result;
};

Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));

List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string command = string.Empty;

while ((command = Console.ReadLine()) != "end")
{
    if (command == "print")
    {
        print(numbers);
    }
    else
    {
        numbers = calculatee(command, numbers);
    }


}