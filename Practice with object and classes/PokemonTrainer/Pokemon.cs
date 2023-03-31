using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Pokemon
    {
        public Pokemon(string namePokemon, string element, int healt)
        {
            Name = namePokemon;
            Element = element;
            Healt = healt;
        }


        public string Name { get; set; }
        public string Element { get; set; }
        public int Healt { get; set; }

        

        



    }
}
