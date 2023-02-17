using System;
using System.Collections.Generic;
using System.Linq;





int priceOfBullet = int.Parse(Console.ReadLine());
int sizeOfBarrel = int.Parse(Console.ReadLine());

Stack<int> bullets = new(
    Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray());

Queue<int> locks = new(
    Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray());


int valueOfIntelligence = int.Parse(Console.ReadLine());

int initialBulletsCount = bullets.Count;

int currentBarrelSize = sizeOfBarrel;


for (int i = 0; i < initialBulletsCount; i++)
{
    if (bullets.Pop() <= locks.Peek())
    {
        Console.WriteLine("Bang!");
        locks.Dequeue();
    }
    else
    {
        Console.WriteLine("Ping!");
    }

    currentBarrelSize--;

    if (currentBarrelSize == 0 && bullets.Any())
    {
        Console.WriteLine("Reloading!");
        currentBarrelSize = sizeOfBarrel;
    }

    if (!bullets.Any() && locks.Any())
    {
        Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
        return;
    }

    if (!locks.Any())
    {
        Console.WriteLine(
            $"{bullets.Count} bullets left. Earned ${valueOfIntelligence - (initialBulletsCount - bullets.Count) * priceOfBullet}");

        return;
    }
}