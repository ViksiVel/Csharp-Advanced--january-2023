using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> stack = new Stack<int>(input);

            string command = Console.ReadLine().ToLower();

            while(command != "end")
            {
                string[] tokens = command.Split();

                if(tokens[0] == "add")
                {
                    int first = int.Parse(tokens[1]);
                    int second = int.Parse(tokens[2]);

                    stack.Push(first);
                    stack.Push(second);
                }
                else if(tokens[0] == "remove")
                {
                    int n = int.Parse((tokens[1]));
                    if (n <= stack.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                    
                }

                command = Console.ReadLine().ToLower();
            }
            int sum = 0;

            while(stack.Count != 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
