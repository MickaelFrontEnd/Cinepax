using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cinepax.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        [Display(Name = "Identifiant")]
        public string Email { get; set; }
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public ICollection<Balance> Balances { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public int TotalToken { get; set; }

        public User()
        {
        }
    }
}
