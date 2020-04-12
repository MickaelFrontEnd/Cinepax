using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cinepax.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public DateTime BookingDate { get; set; }
        public Projection Projection { get; set; }
        public User User { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        [Display(Name = "Nombre de place resérvé")]
        [Range(1, 10)]
        public int SeatBooked { get; set; }
        public int TotalPrice { get; set; }
        [Display(Name = "Type de resérvation")]
        public byte ReservationType { get; set; }

        public Booking()
        {
        }
    }
}
