


































//using System;
//using System.Linq;

//int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

//int rows = sizes[0];
//int cols = sizes[1];

//int[,] matrix = new int[rows, cols];

//for (int row = 0; row < rows; row++)
//{
//    int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    for (int col = 0; col < cols; col++)
//    {
//        matrix[row, col] = data[col];
//    }
//}


//int sumOfColoum = 0;

//for (int col = 0; col < cols; col++)
//{
//    for (int row = 0; row < rows; row++)
//    {
//        sumOfColoum += matrix[row, col];
//    }
//    Console.WriteLine(sumOfColoum);
//    sumOfColoum = 0;
//}



//---------------------------------------------------

//using System;
//using System.Linq;

//string[] sizes = Console.ReadLine().Split(", ");
//int rows = int.Parse(sizes[0]);
//int cols = int.Parse(sizes[1]);

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



//for (int col = 0; col < cols; col++)
//{
//    for (int row = 0; row < rows; row++)
//    {
//        sumOfCol += matrix[row, col];
//    }
//    Console.WriteLine(sumOfCol);
//    sumOfCol = 0;
//}



