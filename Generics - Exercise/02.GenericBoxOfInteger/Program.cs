using System;

namespace _02.GenericBoxOfInteger;

public class Program
{

    static void Main()
    {
        Box<int> box = new Box<int>();


        int n = int.Parse(Console.ReadLine());


        for (int i = 0; i < n; i++)
        {
            int item = int.Parse(Console.ReadLine());

            box.Add(item);
        }


        Console.WriteLine(box.ToString());
    }


}