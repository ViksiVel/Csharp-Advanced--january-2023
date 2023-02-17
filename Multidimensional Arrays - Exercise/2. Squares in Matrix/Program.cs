using System;
using System.Linq;

int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = sizes[0];
int cols = sizes[1];

char[,] matrix = new char[rows, cols];


for (int row = 0; row < rows; row++)
{
    char[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];
    }
}

int counter = 0;

for (int row = 0; row < matrix.GetLength(0) - 1; row++) 
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        //if (row > matrix.GetLength(0) - sizeSquare || col > matrix.GetLength(1) - sizeSquare)
        //{
        //    continue;
        //}

        if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col + 1] && matrix[row, col] == matrix[row + 1, col]) 
        {
            counter++;
        }

    }
}
Console.WriteLine(counter);