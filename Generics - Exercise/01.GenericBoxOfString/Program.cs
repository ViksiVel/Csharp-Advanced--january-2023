﻿using System;

namespace _01.GenericBoxOfString;

public class Program
{

    static void Main()
    {
        Box<string> box = new Box<string>();


        int n = int.Parse(Console.ReadLine());


        for (int i = 0; i < n; i++)
        {
            string item = Console.ReadLine();

            box.Add(item);
        }


        Console.WriteLine(box.ToString());
    }


}