using System;
using _08.Threeuple;



string[] personTokens = Console.ReadLine().Split(' ');
string[] drinkTokens = Console.ReadLine().Split(' ');
string[] numberTokens = Console.ReadLine().Split(' ');


CusstomThreeuple<string, string, string> nameAddress = new($"{personTokens[0]} {personTokens[1]}", personTokens[2], string.Join(" ",personTokens[3..]));
CusstomThreeuple<string, int, bool> drinks = new(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");
CusstomThreeuple<string, double, string> numbers = new(numberTokens[0], double.Parse(numberTokens[1]), numberTokens[2]);



Console.WriteLine(nameAddress);
Console.WriteLine(drinks);
Console.WriteLine(numbers);
