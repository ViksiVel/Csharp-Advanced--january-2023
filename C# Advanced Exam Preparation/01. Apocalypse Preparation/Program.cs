namespace _01._Apocalypse_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int patch = 30;
            int bandage = 40;
            int medKit = 100;

           
            Dictionary<string, int> allMed = new Dictionary<string, int>();
            allMed.Add("MedKit", 0);
            allMed.Add("Bandage", 0);
            allMed.Add("Patch", 0);
            
            

            int[] textileInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] medicamentInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            Stack<int> medicaments = new Stack<int>(medicamentInput);
            Queue<int> textiles = new Queue<int>(textileInput);

            int minLenght = Math.Min(medicaments.Count, textiles.Count);

            while (medicaments.Count != 0 && textiles.Count != 0)
            {
                int sumTextileAndMed = medicaments.Peek() + textiles.Peek();
                if (sumTextileAndMed == patch )
                {
                    allMed["Patch"]++;
                    medicaments.Pop();
                    textiles.Dequeue();

                }
                else if (sumTextileAndMed == bandage)
                {
                    allMed["Bandage"]++;
                    medicaments.Pop();
                    textiles.Dequeue();
                }
                else if (sumTextileAndMed == medKit)
                {
                    allMed["MedKit"]++;
                    medicaments.Pop();
                    textiles.Dequeue();
                }
                else if (sumTextileAndMed > medKit )
                {
                    int sumLeft = Math.Abs(100-(medicaments.Peek() + textiles.Peek()));
                    allMed["MedKit"]++;
                    medicaments.Pop();
                    textiles.Dequeue();
                    int nextMed = medicaments.Pop();

                    int currMed = nextMed + sumLeft;

                    Queue<int> tempQueue = new Queue<int>();
                    Stack<int> tempStack = new Stack<int>();
                    tempStack.Push(currMed);
                    currMed = 0;
                    while (medicaments.Count != 0)
                    {
                        currMed = medicaments.Pop();
                        tempStack.Push(currMed);

                    }

                    while (tempStack.Count != 0)
                    {
                        currMed = tempStack.Pop();
                        medicaments.Push(currMed);

                    }
                }
                else
                {
                    textiles.Dequeue();
                   
                    int curr = medicaments.Pop();

                    int currMed = curr + 10;
                    
                    Queue<int> tempQueue = new Queue<int>();
                    Stack<int> tempStack = new Stack<int>();

                    tempStack.Push(currMed);
                    currMed = 0;
                    while (medicaments.Count != 0)
                    {
                        currMed = medicaments.Pop();
                        tempStack.Push(currMed);

                    }

                    while (tempStack.Count != 0)
                    {
                        currMed = tempStack.Pop();
                        medicaments.Push(currMed);

                    }

                    
                    
                }
            }
            var filteredDictionary = allMed.Where(x => x.Value != 0);

            var sortedDictionary = filteredDictionary.OrderByDescending(x => x.Value).ThenBy(x=>x.Key);

            if (textiles.Count == 0 && medicaments.Count == 0)
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
                foreach (var item in sortedDictionary)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
            else if (textiles.Count == 0)
            {
                Console.WriteLine("Textiles are empty.");
                foreach (var item in sortedDictionary)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }

                Console.WriteLine($"Medicaments left: {string.Join(", ",medicaments)}");
            }
            else if(medicaments.Count == 0)
            {
                Console.WriteLine("Medicaments are empty.");
                
                foreach (var item in sortedDictionary)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }

                Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
            }

            
        }
    }
}