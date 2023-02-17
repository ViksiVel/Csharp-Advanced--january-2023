using System;
using System.Collections.Generic;
using System.Linq;


Queue<string> songs = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));

string input = Console.ReadLine();



while (songs.Any())
{
    string[] tokens = input.Split();

    if (tokens[0] == "Play")
    {
        songs.Dequeue();
    }
    else if (tokens[0] == "Add")
    {
        string newSong = string.Join(" ", tokens.Skip(1));
        if (!songs.Contains(newSong))
        {
            songs.Enqueue(newSong);
        }
        else
        {
            Console.WriteLine($"{newSong} is already contained!");
        }
    }
    else if (tokens[0] == "Show")
    {
        Console.WriteLine(string.Join(", ",songs));
    }

    input = Console.ReadLine();
}
Console.WriteLine("No more songs!");