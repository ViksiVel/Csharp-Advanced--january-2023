using System;


using _07.Tuple;



string[] personTokens = Console.ReadLine().Split(' ');
string[] drinkTokens = Console.ReadLine().Split(' ');
string[] numberTokens = Console.ReadLine().Split(' ');


CusstomTuple<string, string> nameAddress = new($"{personTokens[0]} {personTokens[1]}", personTokens[2]);
CusstomTuple<string, int> nameBeer = new(drinkTokens[0],int.Parse(drinkTokens[1]));
CusstomTuple<int, double> numbers = new(int.Parse(numberTokens[0]), double.Parse(numberTokens[1]));



Console.WriteLine(nameAddress);
Console.WriteLine(nameBeer);
Console.WriteLine(numbers);
