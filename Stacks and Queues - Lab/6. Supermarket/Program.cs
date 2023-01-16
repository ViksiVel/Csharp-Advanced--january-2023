using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<string> queue = new Queue<string>();

            
            while (input != "End") 
            {
                if (input == "Paid")
                {
                    foreach (var item in queue)
                    {
                        Console.WriteLine(item);
                    }
                  queue.Clear();
                }
                else
                {
                    queue.Enqueue(input);
                    
                }
                input = Console.ReadLine();


            }

            Console.WriteLine($"{queue.Count} people remaining.");
























            //string input = Console.ReadLine();

            //while (input != "Paid") 
            //{
            //    Console.WriteLine(input);
            //    input = Console.ReadLine();
            //}
            //input = Console.ReadLine();
            //int count = 0;
            //while (input != "End")
            //{

            //    count++;

            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"{count} people remaining.");


        }
    }
}
