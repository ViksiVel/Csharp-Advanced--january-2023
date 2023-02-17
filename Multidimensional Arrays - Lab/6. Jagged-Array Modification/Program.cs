




































//using System;
//using System.Linq;

//int rows = int.Parse(Console.ReadLine());

//int[][] jaggedArray = new int[rows][];
//for (int row = 0; row < rows; row++)
//{
//    jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
//}

//string input = Console.ReadLine();

//while (input != "END")
//{
//    string[] tokens = input.Split();

//    string command = tokens[0];
//    int row = int.Parse(tokens[1]);
//    int col = int.Parse(tokens[2]);
//    int value = int.Parse(tokens[3]);

//    if (row < 0 || col < 0 || row >= jaggedArray.Length || col >= jaggedArray.Length) 
//    {
//        Console.WriteLine("Invalid coordinates");
//    }
//    else
//    {
//        if (command == "Add")
//        {
//            jaggedArray[row][col] += value;
//        }
//        else
//        {
//            jaggedArray[row][col] -= value;
//        }
//    }

//    input = Console.ReadLine();

//}

//for (int row = 0; row < jaggedArray.Length; row++)
//{
//    for (int col = 0; col < jaggedArray[row].Length; col++)
//    {
//        Console.Write($"{jaggedArray[row][col] + " "}");
//    }
//    Console.WriteLine();
//}