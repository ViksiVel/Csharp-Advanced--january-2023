using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer;
public class Program
{
    static void Main()
    {

        List<Trainers> trainers = new List<Trainers>();

        string input = string.Empty;

        
        while ((input = Console.ReadLine())!= "Tournament")
        {
            string[] tokens = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Trainers trainer = trainers.SingleOrDefault(t => t.Name == tokens[0]);

            if (trainer == null) //Ako nqma dobaven trnior v listta
            {
                trainer = new(tokens[0]);
                trainer.Pokemons.Add(new(tokens[1],tokens[2],int.Parse(tokens[3])));
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

        foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBages))
        {
            Console.WriteLine($"{trainer.Name} {trainer.NumberOfBages} {trainer.Pokemons.Count}");
        }
    }
}