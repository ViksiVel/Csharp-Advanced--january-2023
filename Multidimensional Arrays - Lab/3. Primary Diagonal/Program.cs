


































//using System;
//using System.Linq;

//int size = int.Parse(Console.ReadLine());
//int rows = size;
//int cols = size;

//int[,] matrix = new int[rows, cols];

//for (int row = 0; row < rows; row++)
//{
//    int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

//    for (int col = 0; col < cols; col++)
//    {
//        matrix[row, col] = data[col];
//    }
//}


//int sumOfDiagonals = 0;

//for (int row = 0; row < rows; row++)
//{
//    for (int col = row; col < row+1; col++)
//    {
//        sumOfDiagonals += matrix[col,row];
//    }
//}

//Console.WriteLine(sumOfDiagonals);


//----------------------------------------------

//using System;
//using System.Linq;

//int sizes = int.Parse(Console.ReadLine());
//int rows = sizes;
//int cols = sizes;

//int[,] matrix = new int[rows, cols];

//int sumOfCol = 0;

//for (int row = 0; row < rows; row++)
//{
//    int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    for (int col = 0; col < cols; col++)
//    {
//        matrix[row, col] = data[col];

//    }

//}


//for (int i = 0; i < sizes; i++)
//{
//    sumOfCol += matrix[i, i];
//}

//Console.WriteLine(sumOfCol);