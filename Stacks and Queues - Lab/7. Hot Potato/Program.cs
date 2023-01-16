using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>(Console.ReadLine().Split());
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(names);

            int tosses = 1;
            while (queue.Count != 1)
            {
                string currName = queue.Dequeue();

                if (tosses < n)
                {
                    tosses++;
                    queue.Enqueue(currName);
                    

                }
                else
                {
                    Console.WriteLine($"Removed {currName}");
                    tosses = 1;
                }

            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
