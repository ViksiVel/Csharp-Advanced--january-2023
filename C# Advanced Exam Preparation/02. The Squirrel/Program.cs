namespace _02._The_Squirrel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());

            List<string> positions = new List<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));

            int squirrelRow = -1;
            int squirrelCol = -1;

            int hezelnutCount = 0;
            char[,] matrix = new char[rowsAndCols, rowsAndCols];

            //matrix 
            for (int row = 0; row < rowsAndCols; row++)
            {
                string data = Console.ReadLine();
                for (int col = 0; col < rowsAndCols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            //squirrel Position
            for (int row = 0; row < rowsAndCols; row++)
            {
                for (int col = 0; col < rowsAndCols; col++)
                {
                    if (matrix[row, col] == 's')
                    {
                        squirrelRow = row;
                        squirrelCol = col;
                    }
                }
            }
            
            
            while (hezelnutCount < 3 && positions.Count != 0)
            {
                string possition = positions[0];
                positions.RemoveAt(0);

                if (possition == "left" && squirrelCol - 1 >= 0 )
                {
                    if (matrix[squirrelRow, squirrelCol - 1] == 'h')
                    {
                        hezelnutCount++;
                        matrix[squirrelRow, squirrelCol] = '*';
                        squirrelCol--;
                        matrix[squirrelRow, squirrelCol] = 's';
                    }
                    else if (matrix[squirrelRow, squirrelCol - 1] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        Console.WriteLine($"Hazelnuts collected: {hezelnutCount}");
                        return;
                    }
                    else
                    {
                        matrix[squirrelRow, squirrelCol] = '*';
                        squirrelCol--;
                        matrix[squirrelRow, squirrelCol] = 's';
                    }

                }
                else if (possition == "right" && squirrelCol + 1 < rowsAndCols)
                {
                    if (matrix[squirrelRow, squirrelCol + 1] == 'h')
                    {
                        hezelnutCount++;
                        matrix[squirrelRow, squirrelCol] = '*';
                        squirrelCol++;
                        matrix[squirrelRow, squirrelCol] = 's';
                    }
                    else if (matrix[squirrelRow, squirrelCol + 1] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        Console.WriteLine($"Hazelnuts collected: {hezelnutCount}");
                        return;
                    }
                    else
                    {
                        matrix[squirrelRow, squirrelCol] = '*';
                        squirrelCol++;
                        matrix[squirrelRow, squirrelCol] = 's';
                    }

                }
                else if (possition == "down" &&  squirrelRow + 1 < rowsAndCols )
                {
                    if (matrix[squirrelRow + 1, squirrelCol] == 'h')
                    {
                        hezelnutCount++;
                        matrix[squirrelRow, squirrelCol] = '*';
                        squirrelRow++;
                        matrix[squirrelRow, squirrelCol] = 's';
                    }
                    else if (matrix[squirrelRow + 1, squirrelCol] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        Console.WriteLine($"Hazelnuts collected: {hezelnutCount}");
                        return;
                    }
                    else
                    {
                        matrix[squirrelRow, squirrelCol] = '*';
                        squirrelRow++;
                        matrix[squirrelRow, squirrelCol] = 's';
                    }

                }
                else if (possition == "up" && squirrelRow - 1 >= 0 )
                {
                    if (matrix[squirrelRow - 1, squirrelCol] == 'h')
                    {
                        hezelnutCount++;
                        matrix[squirrelRow, squirrelCol] = '*';
                        squirrelRow--;
                        matrix[squirrelRow, squirrelCol] = 's';
                    }
                    else if (matrix[squirrelRow - 1, squirrelCol] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        Console.WriteLine($"Hazelnuts collected: {hezelnutCount}");
                        return;
                    }
                    else
                    {
                        matrix[squirrelRow, squirrelCol] = '*';
                        squirrelRow--;
                        matrix[squirrelRow, squirrelCol] = 's';
                    }

                }
                else
                {
                    Console.WriteLine("The squirrel is out of the field.");
                    Console.WriteLine($"Hazelnuts collected: {hezelnutCount}");
                    return;
                }

            }

            if (hezelnutCount < 3)
            {
                Console.WriteLine("There are more hazelnuts to collect."); Console.WriteLine($"Hazelnuts collected: {hezelnutCount}");
            }
            else
            {
                Console.WriteLine("Good job! You have collected all hazelnuts!");
                Console.WriteLine($"Hazelnuts collected: {hezelnutCount}");
            }
            
        }
    }
}