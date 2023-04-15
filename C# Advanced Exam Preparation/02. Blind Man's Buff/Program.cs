namespace _02._Blind_Man_s_Buff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int myRow = 0;
            int myCol = 0;

            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] data = Console.ReadLine().Split();
                
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                    if (matrix[row,col] == "B")
                    {
                        myRow = row;
                        myCol = col;
                    }

                }
            }

            int touchedOpponents = 0;
            int makedMoves = 0;

            string commandDirections;

            while ((commandDirections = Console.ReadLine())!= "Finish" && touchedOpponents != 3)
            {
                if (commandDirections == "up" && myRow - 1 >= 0 && matrix[myRow - 1, myCol] != "O")
                {
                    myRow--;
                    makedMoves++;
                }

               else if (commandDirections == "down" && myRow + 1 < rows && matrix[myRow+1,myCol] != "O")
                {
                    myRow++;
                    makedMoves++;
                }

                else if (commandDirections == "right" && myCol + 1 < cols && matrix[myRow, myCol+1] != "O")
                {
                    myCol++;
                    makedMoves++;
                }

               else if (commandDirections == "left" && myCol - 1 >= 0 && matrix[myRow, myCol-1] != "O")
                {
                    myCol--;
                    makedMoves++;
                }

                if (matrix[myRow,myCol] == "P")
                {
                    touchedOpponents++;
                    matrix[myRow,myCol] = "-";
                }
            }


            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {touchedOpponents} Moves made: {makedMoves}");
        }
    }
}