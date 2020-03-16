using System;
using System.Collections.Generic;

namespace PokemonTarea.Models
{
    public partial class Color
    {
        public Color()
        {
            Region = new HashSet<Region>();
        }

        public int IdColor { get; set; }
        public string Color1 { get; set; }

        public virtual ICollection<Region> Region { get; set; }
    }
}
