using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whiteTile  = WhiteTile();
            Queue<int> greyTile =  GreyTile();

            Dictionary<string, int> tiles = new Dictionary<string, int>();
            tiles.Add("Sink", 0);
            tiles.Add("Oven", 0);
            tiles.Add("Countertop", 0);
            tiles.Add("Wall", 0);
            tiles.Add("Floor", 0);


            string commmand = string.Empty;

            while (greyTile.Count != 0 && whiteTile.Count != 0)
            {
                int sum = greyTile.Peek() + whiteTile.Peek();
                bool isTheyEquals = false;

                if (sum == 40)
                {
                    tiles["Sink"]++;
                    whiteTile.Pop();
                    greyTile.Dequeue();
                }
                else if (sum == 50)
                {
                    tiles["Oven"]++;
                    whiteTile.Pop();
                    greyTile.Dequeue();
                }
                else if (sum == 60)
                {
                    tiles["Countertop"]++;
                    whiteTile.Pop();
                    greyTile.Dequeue();
                }
                else if (sum == 70)
                {
                    tiles["Wall"]++;
                    whiteTile.Pop();
                    greyTile.Dequeue();
                }
                else if(greyTile.Peek() == whiteTile.Peek())
                {
                    whiteTile.Pop();
                    greyTile.Dequeue();
                    tiles["Floor"]++;
                }
                else
                {
                    int help = whiteTile.Pop();
                    help /= 2;
                    whiteTile.Push(help);
                    help = greyTile.Dequeue();
                    greyTile.Enqueue(help);
                }



            }

            if (whiteTile.Any())
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTile)}");
            }
            else
            {
                Console.WriteLine("White tiles left: none");
            }

            if (greyTile.Any())
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTile)}");
            }
            else
            {
                Console.WriteLine("Grey tiles left: none");
            }

            //var filtered = tiles.
            foreach (var item in tiles.OrderByDescending(x => x.Value ).ThenBy(x => x.Key).Where(x => x.Value != 0))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }



        //first grey tile 
        public static Queue<int> GreyTile()
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            Queue<int> greyTile = new Queue<int>();
            for (int i = 0; i < input.Length; i++)
            {
                greyTile.Enqueue(input[i]);
            }

            return greyTile;
        }

        //last white tile.
        public static Stack<int> WhiteTile ()
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            Stack<int> whiteTile = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                whiteTile.Push(input[i]);
            }

            return whiteTile;
        }
    }
}