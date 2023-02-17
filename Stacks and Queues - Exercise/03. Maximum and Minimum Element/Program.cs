using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numOfRows = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

           


            for (int i = 0; i < numOfRows; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string command = tokens[0];

                if (command == "1") 
                {
                    string pushedElement = tokens[1];
                    stack.Push(int.Parse(pushedElement));
                }
                else if (command == "2")
                {
                    if (stack.Any())
                    {
                        stack.Pop();
                    }
                    
                }
                else if (command == "3")
                {
                    if (stack.Any())
                    {
                        
                        Console.WriteLine(stack.Max());
                    }
                    
                }
                else if (command == "4")
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Min());
                    }
                }

                
            }

            Console.WriteLine(String.Join(", ",stack));




        }
    }
}
