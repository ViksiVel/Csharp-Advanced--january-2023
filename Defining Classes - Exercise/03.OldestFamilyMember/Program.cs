using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Family family = new Family();

            int numOfPerson = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPerson; i++)
            {
                List<string> personProperties  = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

                Person person = new(personProperties[0], int.Parse(personProperties[1]));

                family.AddMember(person);
            }
            Person oldest = family.GerOldestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");

        }
    }
}