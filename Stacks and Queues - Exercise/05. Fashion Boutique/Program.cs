using System;
using System.Collections.Generic;
using System.Linq;


Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

int capacityOfRack = int.Parse(Console.ReadLine());

int currRack = capacityOfRack;
int counterRack = 1;

while (stack.Any())
{

    currRack -= stack.Peek();

    if (currRack < 0)
    {
        counterRack++;
        currRack = capacityOfRack;
        continue;
    }

    stack.Pop();
}
Console.WriteLine(counterRack);

