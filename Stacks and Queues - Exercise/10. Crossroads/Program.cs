using System;
using System.Collections.Generic;
using System.Linq;



Queue<string> cars = new();

int greenLineSec = int.Parse(Console.ReadLine());
int freeWindow = int.Parse(Console.ReadLine());

string input = "";

int passedCar = 0;


while ((input = Console.ReadLine()) != "END" ) 
{
        if (input != "green")
        {
            cars.Enqueue(input);
            continue;
        }

    int currGreenLine = greenLineSec;

    while (currGreenLine > 0 && cars.Any())
    {
        string currCar = cars.Dequeue();

        if (currGreenLine - currCar.Length >= 0)
        {
            currGreenLine -= currCar.Length;
            passedCar++;
            continue;
        }

        if (currGreenLine + freeWindow - currCar.Length >= 0)
        {
            passedCar++;
            continue;
        }

        int hittedChar = currGreenLine + freeWindow;

        Console.WriteLine("A crash happened!");
        Console.WriteLine($"{currCar} was hit at {currCar[hittedChar]}.");

        return;
    }
}
Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{passedCar} total cars passed the crossroads.");