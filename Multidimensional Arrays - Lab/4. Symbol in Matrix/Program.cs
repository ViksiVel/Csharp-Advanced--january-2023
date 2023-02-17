


































//using System;

//int size = int.Parse(Console.ReadLine());


//char[,] matrix = new char[size, size];

//for (int row = 0; row < size; row++)
//{
//    char[] array = Console.ReadLine().ToCharArray();
//    for (int col = 0; col < size; col++)
//    {
//        matrix[row,col] = array[col];
//    }
//}

//string symbol = Console.ReadLine();

//for (int row = 0; row < size; row++)
//{
//    for (int col = 0; col < size; col++)
//    {
//        if (matrix[col,row].ToString() ==  symbol)
//        {
//            Console.WriteLine($"({col}, {row})");
//            return;
//        }
//    }
//}
//Console.WriteLine($"{symbol} does not occur in the matrix");


//--------------------------------------------------

//using System;

//int size = int.Parse(Console.ReadLine());

//char[,] matrix = new char[size, size];


//for (int row = 0; row < size; row++)
//{
//    char[] array = Console.ReadLine()
//        .ToCharArray();
//    for (int col = 0; col < size; col++)
//    {
//        matrix[row, col] = array[col];
//    }
//}

//string symbol = Console.ReadLine();
//bool isSymbol = false;



//for (int row = 0; row < matrix.GetLength(0); row++)
//{
//    for (int col = 0; col < matrix.GetLength(1); col++)
//    {
//        if (matrix[row,col].ToString() == symbol)
//        {
//            Console.WriteLine($"({row}, {col})");
//            isSymbol = true;
//            return;
//        }
//    }
//}

//if (isSymbol == false)
//{
//    Console.WriteLine($"{symbol} does not occur in the matrix");
//}