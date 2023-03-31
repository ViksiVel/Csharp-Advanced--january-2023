using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer;

public class Startup
{
    static void Main(string[] args)
    {
        string input = string.Empty;

        List<Trainer> trainers = new List<Trainer>();   

        while ((input = Console.ReadLine()) != "Tournament")
        {
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //SingleOrDefault -> Returns a single, specific element of a sequence, or a default value if that element is not found.
            Trainer trainer = trainers.SingleOrDefault(t=>t.Name == tokens[0]);

            if (trainer == null)
            {
                trainer = new(tokens[0]);
                trainer.Pokemons.Add(new(tokens[1], tokens[2], int.Parse(tokens[3])));
                trainers.Add(trainer);
            }
            else
            {
                trainer.Pokemons.Add(new(tokens[1], tokens[2], int.Parse(tokens[3])));
            }
        }
        while ((input = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers)
            {
                trainer.CheckPokemon(input);
            }
        }

        foreach (var trainer in trainers.OrderByDescending(t=>t.NumberOfBadges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
        }
    }
}
