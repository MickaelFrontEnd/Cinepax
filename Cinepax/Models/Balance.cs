
namespace Cinepax.Models
{
    public class Balance
    {
        public int ID { get; set; }
        public User User { get; set; }
        public int Debit { get; set; }
        public int Credit { get; set; }
        public int Reste { get; set; }

        public Balance()
        {
        }
    }
}
