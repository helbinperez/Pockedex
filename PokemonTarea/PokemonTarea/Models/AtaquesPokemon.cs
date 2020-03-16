using System;
using System.Collections.Generic;

namespace PokemonTarea.Models
{
    public partial class AtaquesPokemon
    {
        public int IdAtaquesPokemon { get; set; }
        public int PokemonId { get; set; }
        public int AtaquesId { get; set; }

        public virtual Ataques Ataques { get; set; }
        public virtual Pokemon Pokemon { get; set; }
    }
}
