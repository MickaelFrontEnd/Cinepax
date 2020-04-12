
using System.Collections.Generic;
using System.Linq;
using Cinepax.Models;

namespace Cinepax.Services
{
    public class BookingService
    {
        public Movie GetMovie(int id)
        {
            using(CinepaxContext cinepaxContext = new CinepaxContext())
            {
                return cinepaxContext.Movies.Find(id);
            }
        }

        public int Book(Booking booking)
        {
            booking.TotalPrice = booking.Projection.Price * booking.SeatBooked;

            if(booking.ReservationType == 1)
            {
                booking.TotalPrice *= 2;
            }

            // Check if user has the required amount of token
            if (booking.TotalPrice > booking.User.TotalToken) throw new System.Exception($"Votre solde est insuffisant pour effectuer cette resérvation, solde = {booking.User.TotalToken}, jeton necessaire = {booking.TotalPrice}");


            using(CinepaxContext cinepaxContext = new CinepaxContext())
            {
                // Update user total token
                User actualUser = cinepaxContext
                    .Users
                    .Find(booking.User.ID);
                int amountBefore = actualUser.TotalToken;
                actualUser.TotalToken -= booking.TotalPrice;
               

                // Add transaction
                cinepaxContext
                    .Transactions
                    .Add(new Transaction()
                    {
                        User = booking.User,
                        Projection = booking.Projection,
                        Description = $"Resérvation du film <<{booking.Projection.Movie.Name}>> du <<{booking.Projection.ProjectionDate}>>",
                        AmountBefore = amountBefore,
                        AmountAfter = actualUser.TotalToken
                    }) ;

                // Add booking
                cinepaxContext
                    .Bookings
                    .Add(booking);


                return cinepaxContext.SaveChanges();
            }
        }

        public List<Booking> GetList()
        {
            List<Booking> result = new List<Booking>();
            using (CinepaxContext cinepaxContext = new CinepaxContext())
            {
                result = cinepaxContext
                    .Bookings
                    .Include("Projection")
                    .Include("Projection.Movie")
                    .Include("Projection.Room")
                    .Include("User")
                    .ToList();
            }
            return result;
        }

        public List<Booking> GetAll(User user)
        {
            List<Booking> result = new List<Booking>();
            using (CinepaxContext cinepaxContext = new CinepaxContext())
            {
                var query = cinepaxContext
                    .Bookings
                    .Include("Projection")
                    .Include("Projection.Movie")
                    .Include("Projection.Room")
                    .Include("User")
                    .Where(x => x.User.ID == user.ID);

                result = query.ToList();
            }
            return result;
        }

    public Booking GetBooking(int id)
        { 
            using (CinepaxContext cinepaxContext = new CinepaxContext())
            {
                return cinepaxContext
                    .Bookings
                    .Include("Projection")
                    .Include("Projection.Movie")
                    .Include("Projection.Room")
                    .Include("User")
                    .Where(x => x.ID == id)
                    .First();
            }
        }
    }
}
