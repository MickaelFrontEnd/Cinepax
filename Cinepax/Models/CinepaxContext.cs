using System.Data.Entity;

namespace Cinepax.Models
{
    public class CinepaxContext:DbContext
    {
        public CinepaxContext():base("Cinepax")
        {
        }

        public DbSet<Balance> Balances { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Projection> Projections { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; } 
    }
}
