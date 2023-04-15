namespace _01._Rubber_Duck_Debugers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> programmerTime = ProgrammerTime();
            Stack<int> programmerTask = Task();

            Dictionary<string, int> programmerWork = new Dictionary<string, int>();
            programmerWork.Add("Darth Vader Ducky",0);
            programmerWork.Add("Thor Ducky", 0);
            programmerWork.Add("Big Blue Rubber Ducky", 0);
            programmerWork.Add("Small Yellow Rubber Ducky", 0);


            while (programmerTime.Any() && programmerTask.Any())
            {
                int time = programmerTime.Peek() * programmerTask.Peek();

                if (time >= 0 && time <= 60)
                {
                    programmerWork["Darth Vader Ducky"]++;
                    programmerTime.Dequeue();
                    programmerTask.Pop();
                }
                else if (time >= 61 && time <= 120)
                {
                    programmerWork["Thor Ducky"]++;
                    programmerTime.Dequeue();
                    programmerTask.Pop();
                }
                else if (time >= 121 && time <= 180)
                {
                    programmerWork["Big Blue Rubber Ducky"]++;
                    programmerTime.Dequeue();
                    programmerTask.Pop();
                }
                else if (time >= 181 && time <= 240)
                {
                    programmerWork["Small Yellow Rubber Ducky"]++;
                    programmerTime.Dequeue();
                    programmerTask.Pop();
                }
                else if (time >= 241)
                {
                    int help = programmerTask.Pop();
                    help -= 2;
                    programmerTask.Push(help);
                    help = programmerTime.Dequeue();
                    programmerTime.Enqueue(help);
                }
            }

            Console.WriteLine($"Congratulations, all tasks have been completed! Rubber ducks rewarded:");

            foreach (var task in programmerWork)
            {
                Console.WriteLine($"{task.Key}: {task.Value}");
            }

        }

        public static Queue<int> ProgrammerTime()
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            Queue<int> programmerQueue = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                programmerQueue.Enqueue(input[i]);
            }

            return programmerQueue;
        }

        public static Stack<int> Task()
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            Stack<int> taskStack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                taskStack.Push(input[i]);
            }

            return taskStack;
        }
    }
}