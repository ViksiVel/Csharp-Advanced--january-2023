using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int> numbers = new List<int>(Console.ReadLine().Split().Select(int.Parse));

            Queue<int> queue = new Queue<int>(numbers);

            Queue<int> newQueue = new Queue<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (queue.Peek() % 2 == 0)
                {
                    int currNum = queue.Peek();
                    newQueue.Enqueue(currNum);
                }
                queue.Dequeue();
            }

            Console.WriteLine($"{string.Join(", ", newQueue)}");
        }
    }
}
