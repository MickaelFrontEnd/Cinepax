using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Cinepax.Models;
using Cinepax.Services;

namespace Cinepax.Controllers
{
    public class BookingController : Controller
    {
        private ProjectionService projectionService = new ProjectionService();
        private BookingService bookingService = new BookingService();

        [HttpGet]
        public ActionResult Index(int id)
        {
            Booking booking = new Booking();
            booking.Projection = projectionService.GetProjection(id);

            ViewBag.Title = "Resérver votre place";

            return View (booking);
        }

        [HttpPost]
        public ActionResult Index(Booking booking)
        {
            try
            {
                booking.BookingDate = DateTime.Now;
                booking.User = (User)Session["user"];
                booking.Projection = projectionService.GetProjection(booking.Projection.ID);
                bookingService.Book(booking);

                return RedirectToAction("List");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                ViewBag.AmountError = ex.Message;
                return View(booking);
            }
        }

        public ActionResult List()
        {
            List<Booking> bookings = bookingService.GetList();

            ViewBag.Title = "Vos resérvations";

            return View(bookings);
        }

        public ActionResult PrintPDF(int id)
        {
            Booking booking = bookingService.GetBooking(id);
            var document = Utils.PrintPDF(booking);
            var cd = new System.Net.Mime.ContentDisposition
            {
                FileName = $"Reçu de {booking.User.FirstName} {booking.User.Lastname}",
                Inline = false,
            };
            Response.AppendHeader("Content-Disposition", cd.ToString());
            return File(document.BinaryData, "application/pdf");
        }
    }
}
