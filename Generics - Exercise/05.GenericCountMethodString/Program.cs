using System;

namespace _05.GenericCountMethodString;

public class Program
{
    static void Main()
    {
        Box<string> box = new Box<string>();

        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string item = Console.ReadLine();

            box.Add(item);
        }

        string itemToCompare = Console.ReadLine();

        Console.WriteLine(box.Count(itemToCompare));
    }
}



