using System;
using System.Collections.Generic;

namespace Cinepax.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Projection> Projections { get; set; }

        public Room()
        {
        }
    }
}
