using System;
using System.Collections.Generic;

namespace PokemonTarea.Models
{
    public partial class TipoPokemon
    {
        public TipoPokemon()
        {
            Pokemon = new HashSet<Pokemon>();
        }

        public int IdTipo { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Pokemon> Pokemon { get; set; }
    }
}
