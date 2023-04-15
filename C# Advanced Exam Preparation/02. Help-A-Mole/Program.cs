using System;
using System.Linq;

namespace _02._Help_A_Mole
{
    internal class Program
    {
        public static
             int rowAndCol = int.Parse(Console.ReadLine());
        public static
             int moleRow = -1;
        public static
             int moleCol = -1;
        public static
             char[,] matrix = new char[rowAndCol, rowAndCol];


        public static
             int firstSpecialLocationRow = -1;
        public static
             int firstSpecialLocationCol = -1;
        public static
             int secondSpecialLocationRow = -1;
        public static
             int secondSpecialLocationCol = -1;

        public static int molePoints = 0;
        static void Main(string[] args)
        {


            //create the playing field
            for (int row = 0; row < rowAndCol; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < rowAndCol; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            //find Mole's position
            for (int row = 0; row < rowAndCol; row++)
            {
                for (int col = 0; col < rowAndCol; col++)
                {
                    if (matrix[row, col] == 'M')
                    {
                        moleRow = row;
                        moleCol = col;
                        break;
                    }
                }
            }
            //find speacial locations' positions
            for (int row = 0; row < rowAndCol; row++)
            {
                for (int col = 0; col < rowAndCol; col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        if (firstSpecialLocationRow < 0 && firstSpecialLocationCol < 0)
                        {
                            firstSpecialLocationRow = row;
                            firstSpecialLocationCol = col;
                        }
                        else
                        {
                            secondSpecialLocationRow = row;
                            secondSpecialLocationCol = col;
                        }
                    }
                }
            }





            // start receiving directions
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End" && molePoints < 25)
            {
                if (command == "up")
                {
                    Move(-1, 0);
                }
                else if (command == "down")
                {

                    Move(1, 0);
                }
                else if (command == "left")
                {

                    Move(0, -1);
                }
                else if (command == "right")
                {

                    Move(0, 1);
                }
            }

            if (molePoints < 25)
            {
                Console.WriteLine($"Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {molePoints} points.");
            }
            else
            {
                Console.WriteLine($"Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {molePoints} points.");
            }

            for (int row = 0; row < rowAndCol; row++)
            {
                for (int col = 0; col < rowAndCol; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }


        private static void Move(int row, int col)
        {
            if (isInside(moleRow + row, moleCol + col))
            {
                if (matrix[moleRow + row, moleCol + col] == '-')
                {
                    matrix[moleRow, moleCol] = '-';
                    moleRow += row;
                    moleCol += col;
                }
                else if (char.IsDigit(matrix[moleRow + row, moleCol + col]))
                {
                    matrix[moleRow, moleCol] = '-';
                    moleRow += row;
                    moleCol += col;
                    molePoints += int.Parse(matrix[moleRow, moleCol].ToString());
                    matrix[moleRow, moleCol] = 'M';
                }
                else if (matrix[moleRow + row, moleCol + col] == 'S')
                {
                    matrix[moleRow, moleCol] = '-';
                    moleRow += row;
                    moleCol += col;
                    if (moleRow == firstSpecialLocationRow && moleCol == firstSpecialLocationCol)
                    {
                        moleRow = secondSpecialLocationRow;
                        moleCol = secondSpecialLocationCol;
                        matrix[firstSpecialLocationRow, firstSpecialLocationCol] = '-';
                    }
                    else if (moleRow == secondSpecialLocationRow && moleCol == secondSpecialLocationCol)
                    {
                        moleRow = firstSpecialLocationRow;
                        moleCol = firstSpecialLocationCol;
                        matrix[secondSpecialLocationRow, secondSpecialLocationCol] = '-';
                    }

                    molePoints -= 3;
                }

                matrix[moleRow, moleCol] = 'M';
            }
            else
            {
                Console.WriteLine("Don't try to escape the playing field!");
            }


        }

        private static bool isInside(int row, int col)
        {
            //return row >= 0 && row < playingField.GetLength(0) && col >= 0 && col < playingField.GetLength(1);
            return row >= 0 && row < rowAndCol && col >= 0 && col < rowAndCol;
        }
    }
}