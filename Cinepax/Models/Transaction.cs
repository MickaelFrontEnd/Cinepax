
namespace Cinepax.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public User User { get; set; }
        public Projection Projection { get; set; }
        public string Description { get; set; }
        public int AmountBefore { get; set; }
        public int AmountAfter { get; set; }

        public Transaction()
        {
        }
    }
}
