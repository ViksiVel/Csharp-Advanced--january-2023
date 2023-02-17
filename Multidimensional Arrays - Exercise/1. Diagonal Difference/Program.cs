using System;
using System.Linq;

int sizes = int.Parse(Console.ReadLine());

int rows = sizes;
int cols = sizes;

int[,] matrix = new int[rows, cols];   


for (int row = 0; row < rows; row++)
{
    int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];
    }
}
int sumFirstDiagonal = 0;
int sumSecondDiagonal = 0;

for (int i = 0; i < sizes; i++)
{
    sumFirstDiagonal +=  matrix[i,i];
    sumSecondDiagonal += matrix[sizes-i-1,i];
}

Console.WriteLine($"{Math.Abs(sumFirstDiagonal-sumSecondDiagonal)}");