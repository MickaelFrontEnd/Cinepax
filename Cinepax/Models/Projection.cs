using System;
namespace Cinepax.Models
{
    public class Projection
    {
        public int ID { get; set; }
        public DateTime ProjectionDate { get; set; }
        public Room Room { get; set; }
        public Movie Movie { get; set; }
        public int Price { get; set; }

        public Projection()
        {
        }
    }
}
