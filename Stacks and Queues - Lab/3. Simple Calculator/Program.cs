using System;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            List<string> input = new List<string>(Console.ReadLine().Split());

            Stack<string> stack = new Stack<string>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }
            int sum  = 0;
            while (stack.Count != 0)
            {
                if (stack.Peek() != "+" && stack.Peek() != "-")
                {
                    int num = int.Parse(stack.Peek());
                    sum += num;
                    stack.Pop();
                }
                
                else if (stack.Peek() == "-")
                {
                    stack.Pop();
                    int num = int.Parse(stack.Peek());
                    sum -= num;
                    stack.Pop();
                }
                else if (stack.Peek() == "+")
                {
                    stack.Pop();
                    int num = int.Parse(stack.Peek());
                    sum += num;
                    stack.Pop();
                }
            }

            Console.WriteLine(sum);

















            //List<string> input = new List<string>(Console.ReadLine().Split());
            //int sum = 0;
            //for (int i = 0; i < input.Count; i++)
            //{
            //    if (input[i] == "+")
            //    {
            //        if (i <= 1)
            //        {
            //            int numFirs = int.Parse(input[i - 1]);

            //            int numSec = int.Parse(input[i + 1]);
            //            int tot = numFirs + numSec;
            //            sum += tot;
            //        }
            //        else
            //        {

            //            int numSec = int.Parse(input[i + 1]);
            //            sum +=  numSec;
            //        }

            //    }
            //    else if (input[i] == "-")
            //    {
            //        if (i <= 1)
            //        {
            //            int numFirs = int.Parse(input[i - 1]);

            //            int numSec = int.Parse(input[i + 1]);
            //            int tot = numFirs - numSec;
            //            sum -= tot;
            //        }
            //        else
            //        {

            //            int numSec = int.Parse(input[i + 1]);
            //            sum -= numSec;
            //        }
            //    }
            //}

            //Console.WriteLine(sum);



        }
    }
}
