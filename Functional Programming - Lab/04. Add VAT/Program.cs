using System;
using System.Collections.Generic;
using System.Linq;

List<double> numbers = new List<double>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList());

List<double> vatNum = new List<double>();

Func<double, double> vatWithNum = (num1) => num1 += num1 * 0.20;


foreach (var num in numbers)
{
    double currNum = num;
    vatNum.Add(vatWithNum(currNum));
}

foreach (var item in vatNum)
{
    Console.WriteLine($"{item:f2}");
}
