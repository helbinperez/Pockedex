using System;
using System.Collections.Generic;

namespace PokemonTarea.Models
{
    public partial class Region
    {
        public Region()
        {
            Pokemon = new HashSet<Pokemon>();
        }

        public int IdRegion { get; set; }
        public string Region1 { get; set; }
        public int? Color { get; set; }

        public virtual Color ColorNavigation { get; set; }
        public virtual ICollection<Pokemon> Pokemon { get; set; }
    }
}
