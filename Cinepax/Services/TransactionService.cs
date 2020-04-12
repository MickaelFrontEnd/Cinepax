
using System.Collections.Generic;
using System.Linq;
using Cinepax.Models;

namespace Cinepax.Services
{
    public class TransactionService
    {
        public List<Transaction> GetList()
        {
            List<Transaction> result = new List<Transaction>();
            using (CinepaxContext cinepaxContext = new CinepaxContext())
            {
                result = cinepaxContext
                    .Transactions
                    .Include("User")
                    .Include("Projection")
                    .ToList();
            }
            return result;
        }
    }
}
