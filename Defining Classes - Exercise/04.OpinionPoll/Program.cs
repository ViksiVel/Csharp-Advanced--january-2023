using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            List<Person> personOver30 = new List<Person>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personProp = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //first way
                string name = personProp[0];
                int age = int.Parse(personProp[1]);
                Person person = new(name, age);

                //second way -> without variables
                // Person person = new(personProperties[0], int.Parse(personProperties[1]));

                if (person.Age > 30)
                {
                    personOver30.Add(person);
                }

            }

            foreach (var person in personOver30.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }



        }
    }
}