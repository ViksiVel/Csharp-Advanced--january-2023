using System;
using System.Linq;
using _03.GenericSwapMethodString;




Box<string> box = new Box<string>();


int n = int.Parse(Console.ReadLine());


for (int i = 0; i < n; i++)
{
    string item = Console.ReadLine();

    box.Add(item);
}

int[] indexes = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

box.Swap(indexes[0], indexes[1]);

Console.WriteLine(box.ToString());