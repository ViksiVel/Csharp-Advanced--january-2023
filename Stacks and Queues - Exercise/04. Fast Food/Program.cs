using System;
using System.Collections.Generic;
using System.Linq;

int quantity = int.Parse(Console.ReadLine());
//int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

int bigestOrder = orders.Max();

int counter = orders.Count();
while(orders.Count != 0)
{

    if (quantity - orders.Peek() >= 0)
    {
        quantity -=orders.Peek();
        orders.Dequeue();
      
    }
    else if (quantity - orders.Peek() < 0)
    {
        //orders.Dequeue();
        break;
    }
   
}

if (orders.Any())
{
    Console.WriteLine(bigestOrder);
    Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
}
else
{
    Console.WriteLine(bigestOrder);
    Console.WriteLine($"Orders complete");
}


