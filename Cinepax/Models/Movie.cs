using System;
using System.Collections.Generic;

namespace Cinepax.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public short Type { get; set; }
        public ICollection<Projection> Projections { get; set; }

        public Movie()
        {
        }
    }
}
