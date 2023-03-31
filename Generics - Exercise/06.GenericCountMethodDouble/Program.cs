using System;

namespace _06.GenericCountMethodDouble;

public class Program
{
    static void Main()
    {
        Box<double> box = new Box<double>();

        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            double item = double.Parse(Console.ReadLine());

            box.Add(item);
        }

        double itemToCompare = double.Parse(Console.ReadLine());

        Console.WriteLine(box.Count(itemToCompare));
    }
}



