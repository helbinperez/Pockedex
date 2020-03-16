using System;
using System.Collections.Generic;

namespace PokemonTarea.Models
{
    public partial class Ataques
    {
        public Ataques()
        {
            AtaquesPokemon = new HashSet<AtaquesPokemon>();
        }

        public int IdAtaque { get; set; }
        public string Ataque { get; set; }

        public virtual ICollection<AtaquesPokemon> AtaquesPokemon { get; set; }
    }
}
