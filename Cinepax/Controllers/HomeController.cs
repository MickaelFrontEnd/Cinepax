using System;
using System.Web.Mvc;
using Cinepax.Models;
using Cinepax.Services;

namespace Cinepax.Controllers
{
    public class HomeController : Controller
    {

        private UserService userService = new UserService();
        public BookingService projectionService = new BookingService();

        [HttpGet]
        public ActionResult Index()
        {
            //CinepaxDbInitializer.InitData();
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            try
            {
                Session["user"] = userService.Login(user);
                return RedirectToAction("Index", "Projection");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                ViewBag.Error = ex.Message;
                return View(user);
            }
            
        }

        public ActionResult LogOut()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }

        public ActionResult Calendar()
        {
            ViewBag.Title = "Votre agenda";

            return View(projectionService.GetAll((User)Session["user"]));
        }

        
    }
}
