namespace _02._Rally_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixDemensions = int.Parse(Console.ReadLine());
            string nameOfCar = Console.ReadLine();

            string[,] matrix = new string[matrixDemensions, matrixDemensions];

            bool isItFinished = false;
            int carRow = 0;
            int carCol = 0;

            for (int row = 0; row < matrixDemensions; row++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrixDemensions; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            int countKM = 0;

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string command = input;
                switch (command)
                {
                    case "left":
                        carCol--;
                        break;
                    case "right":
                        carCol++;
                        break;
                    case "up":
                        carRow--;
                        break;
                    case "down":
                        carRow++;
                        break;
                }

                if (matrix[carRow,carCol] == ".")
                {
                    countKM += 10;
                    continue;
                }
                else
                {
                    if (matrix[carRow, carCol] == "T")
                    {
                        countKM += 30;
                        matrix[carRow, carCol] = ".";
                        bool tunelPassed = false;

                        for (int row = 0; row < matrixDemensions; row++)
                        {
                           
                            for (int col = 0; col < matrixDemensions; col++)
                            {
                                if (matrix[row,col] == "T")
                                {
                                    carRow = row;
                                    carCol = col;
                                    tunelPassed = true;
                                    matrix[row,col] = ".";
                                    break;
                                }
                                
                            }

                            if (tunelPassed)
                            {
                                break;
                            }
                        }

                    }
                    else
                    {
                        isItFinished = true;
                        countKM += 10;
                        break;
                    }
                }
            }

            matrix[carRow,carCol] = "C";

            if (isItFinished)
            {
                Console.WriteLine($"Racing car {nameOfCar} finished the stage!");
            }
            else
            {
                Console.WriteLine($"Racing car {nameOfCar} DNF.");
            }

            Console.WriteLine($"Distance covered {countKM} km.");

            for (int row = 0; row < matrixDemensions; row++)
            {
                
                for (int col = 0; col < matrixDemensions; col++)
                {
                    Console.Write(matrix[row,col]);
                }

                Console.WriteLine();
            }

        }
    }
}