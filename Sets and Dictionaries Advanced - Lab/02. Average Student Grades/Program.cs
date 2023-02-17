using System;
using System.Collections.Generic;
using System.Linq;


int numOfInputs = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

string input =string.Empty;

for (int i = 0; i < numOfInputs; i++)
{
    input = Console.ReadLine();
    string[] tokens = input.Split();

    string name = tokens[0];
    decimal grade = decimal.Parse(tokens[1]);



    if (!grades.ContainsKey(name))
    {
        grades.Add(name, new List<decimal>());
    }

    grades[name].Add(grade);


    
}

foreach (var student in grades)
{
    Console.WriteLine($"{student.Key} -> {string.Join(" ",student.Value.Select(x=>$"{x:f2}").ToList())} (avg: {student.Value.Average():f2})");
}