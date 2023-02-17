using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> inputs = new List<int>(Console.ReadLine().Split().Select(int.Parse));

            int numOfElements = inputs[0];
            int numOfPopedElements = inputs[1];
            int numWhoWeLookingFor = inputs[2];

            List<int> numbers = new List<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> queue = new Queue<int>(numbers);

            for (int i = 0; i < numOfPopedElements; i++)
            {
                queue.Dequeue();
            }

            //if (queue.Contains(numWhoWeLookingFor))
            //{
            //    Console.WriteLine("true");
            //}
            //else if (queue.Count == 0)
            //{
            //    Console.WriteLine("0");
            //}
            //else if (!queue.Contains(numWhoWeLookingFor))
            //{
            //    int minElem = queue.Min();
            //    Console.WriteLine(minElem);
            //}

            if (queue.Contains(numWhoWeLookingFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Any())
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }

        }
    }
}
