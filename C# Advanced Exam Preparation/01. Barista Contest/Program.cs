using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Barista_Contest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cortado = 50;
            int espresso = 75;
            int capuccino = 100;
            int americano = 150;
            int latte = 200;

            Queue<int> coffeeQuantity = CoffeeQuantity();
            Stack<int> milkQuantity = MilkQuantity();

            Dictionary<string, int> drinks = new Dictionary<string, int>();
            drinks.Add("Cortado",0);
            drinks.Add("Espresso", 0);
            drinks.Add("Capuccino", 0);
            drinks.Add("Americano", 0);
            drinks.Add("Latte", 0);


            while (coffeeQuantity.Count != 0 && milkQuantity.Count != 0)
            {
                int sum = coffeeQuantity.Peek() + milkQuantity.Peek();

                switch (sum)
                {
                    case 50:
                        drinks["Cortado"]++;
                        coffeeQuantity.Dequeue();
                        milkQuantity.Pop();
                        break;
                    case 75:
                        drinks["Espresso"]++;
                        coffeeQuantity.Dequeue();
                        milkQuantity.Pop();
                        break;
                    case 100:
                        drinks["Capuccino"]++;
                        coffeeQuantity.Dequeue();
                        milkQuantity.Pop();
                        break;
                    case 150:
                        drinks["Americano"]++;
                        coffeeQuantity.Dequeue();
                        milkQuantity.Pop();
                        break;
                    case 200:
                        drinks["Latte"]++;
                        coffeeQuantity.Dequeue();
                        milkQuantity.Pop();
                        break;
                    default:
                        coffeeQuantity.Dequeue();
                        int help = milkQuantity.Pop();
                        help -= 5;
                        milkQuantity.Push(help);
                        break;
                }
            }

            if (!milkQuantity.Any() && !coffeeQuantity.Any())
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else if(milkQuantity.Any() || coffeeQuantity.Any())
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }

            if (coffeeQuantity.Any())
            {
                Console.WriteLine($"Coffee left: {string.Join(", ",coffeeQuantity)}");
            }
            else if (!coffeeQuantity.Any())
            {
                Console.WriteLine("Coffee left: none");
            }
            if (milkQuantity.Any())
            {
                Console.WriteLine($"Milk left: {string.Join(", ", milkQuantity)}");
            }
            else if (!milkQuantity.Any())
            {
                Console.WriteLine("Milk left: none");
            }

            var filterDictionary = drinks.Where(x => x.Value != 0);
            var sortDictionary = filterDictionary.OrderBy(x => x.Value).ThenByDescending(x=>x.Key);

            foreach (var drink in sortDictionary)
            {
                Console.WriteLine($"{drink.Key}: {drink.Value}");
            }

        }


        public static Queue<int> CoffeeQuantity()
        {
            int[] input = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> coffeeQueue = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                coffeeQueue.Enqueue(input[i]);
            }

            return coffeeQueue;
        }



        public static Stack<int> MilkQuantity()
        {
            int[] input = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> milkStack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                milkStack.Push(input[i]);

            }


            return milkStack;


        }
    }
}