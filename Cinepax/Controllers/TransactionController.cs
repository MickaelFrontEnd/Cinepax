using System.Collections.Generic;
using System.Web.Mvc;
using Cinepax.Models;
using Cinepax.Services;

namespace Cinepax.Controllers
{
    public class TransactionController : Controller
    {
        private TransactionService transactionService = new TransactionService();


        public ActionResult Index()
        {

            List<Transaction> transactions = transactionService.GetList();

            ViewBag.Title = "Vos transactions";

            return View(transactions);
        }
    }
}
