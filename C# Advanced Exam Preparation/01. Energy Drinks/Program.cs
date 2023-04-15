namespace _01._Energy_Drinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxCaffeine = 300;
            int stamatsCaffeine = 0;


            Stack<int> caffeine = CaffeineConsoleInput();
            Queue<int> drinks = DrinksConsoleInput();


            while (caffeine.Count != 0 && drinks.Count != 0)
            {
                int sumOfEnergyAndCaffeine = caffeine.Peek() * drinks.Peek();

                if (sumOfEnergyAndCaffeine +stamatsCaffeine <= maxCaffeine)
                {
                    
                    caffeine.Pop();
                    drinks.Dequeue();
                    stamatsCaffeine += sumOfEnergyAndCaffeine;

                }

                else 
                {
                    caffeine.Pop();

                    drinks.Enqueue(drinks.Dequeue());

                    if (stamatsCaffeine < 30)
                    {
                        stamatsCaffeine = 30;
                    }

                    stamatsCaffeine -= 30;
                    
                }
            }

            if (drinks.Any())
            {
                Console.WriteLine($"Drinks left: {string.Join(", ",drinks)}");
            }
            else 
            {
                Console.WriteLine($"At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {stamatsCaffeine} mg caffeine.");

        }


        public static Stack<int> CaffeineConsoleInput()
        {
            int[] input = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> caffeine = new Stack<int>(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                caffeine.Push(input[i]);
            }

            return caffeine;
        }

        public static Queue<int> DrinksConsoleInput()
        {
            int[] input = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> drinks = new Queue<int>(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                drinks.Enqueue(input[i]);
            }

            return drinks;


        }
    }
}