using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Trainers
    {
        public Trainers(string name)
        {
            Name = name;
            Pokemons = new();
        }


        public string Name { get; set; }
        public int NumberOfBages { get; set; }
        public List<Pokemon> Pokemons { get; set; }


        public void CheckPokemon(string element)
        {
            if (Pokemons.Any(p => p.Element == element)) //tyk proverqvame dali ima izobshto nqkakuv pokemon s elementa daden ot konzolata, ako ima yvelichavame bages
            {
                NumberOfBages++;
            }
            else//tyk nqmame takuv pokemon za tova puskame for  cikul koito da namali zdraveto na vseki pokemon s 10
            {
                for (int i = 0; i < Pokemons.Count; i++)
                {
                    Pokemon currentPokemon = Pokemons[i];

                    currentPokemon.Healt -= 10;

                    if (currentPokemon.Healt <= 0)
                    {
                        Pokemons.Remove(currentPokemon);
                    }
                }
            }
        }


    }
}
