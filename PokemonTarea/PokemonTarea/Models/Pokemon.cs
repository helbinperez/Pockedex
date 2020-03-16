using System;
using System.Collections.Generic;

namespace PokemonTarea.Models
{
    public partial class Pokemon
    {
        public Pokemon()
        {
            AtaquesPokemon = new HashSet<AtaquesPokemon>();
        }

        public int IdPokemon { get; set; }
        public string Nombre { get; set; }
        public int? Tipo { get; set; }
        public int? Region { get; set; }

        public virtual Region RegionNavigation { get; set; }
        public virtual TipoPokemon TipoNavigation { get; set; }
        public virtual ICollection<AtaquesPokemon> AtaquesPokemon { get; set; }
    }
}
