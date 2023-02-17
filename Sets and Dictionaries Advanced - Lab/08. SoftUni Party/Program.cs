using System;
using System.Linq;
using System.Collections.Generic;


string input = string.Empty;

HashSet<string> guests = new HashSet<string>();
while ((input = Console.ReadLine()) != "PARTY")
{
    guests.Add(input);
}
while ((input = Console.ReadLine()) != "END")
{
    if (guests.Contains(input))
    {
        guests.Remove(input);
    }


}

Console.WriteLine(guests.Count);

foreach (var guest in guests)
{
    char[] ch = guest.ToCharArray();
    if (char.IsDigit(ch[0]))
    {
        Console.WriteLine(guest);
    }
    
}
foreach (var guest in guests)
{
    char[] ch = guest.ToCharArray();
    if (char.IsLetter(ch[0]))
    {
        Console.WriteLine(guest);
    }

}