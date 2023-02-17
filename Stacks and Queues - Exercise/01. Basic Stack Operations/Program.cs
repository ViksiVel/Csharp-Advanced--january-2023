using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
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
            Stack<int> stack = new Stack<int>(numbers);
            
            for (int i = 0; i < numOfPopedElements; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(numWhoWeLookingFor))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (!stack.Contains(numWhoWeLookingFor))
            {
               int minElem =  stack.Min();
                Console.WriteLine(minElem);
            }

        }
    }
}
