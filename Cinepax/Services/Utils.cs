
using System;
using System.IO;
using System.Text;
using Cinepax.Models;
using IronPdf;

namespace Cinepax.Services
{
    public class Utils
    {
        public static int GetOffset(int page, int total)
        {
            return (page - 1) * total;
        }

        public static PdfDocument PrintPDF(Booking booking)
        {
            var Renderer = new HtmlToPdf();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<h1>Reçu de resérvation CINEPAX</h1>");
            stringBuilder.Append("<p><b>Client:</b>" + booking.User.FirstName + " " + booking.User.Lastname + "</p>");
            stringBuilder.Append("<p><b>Film:</b>" + booking.Projection.Movie.Name +"</p>");
            stringBuilder.Append("<p><b>Date:</b>" + booking.Projection.ProjectionDate + "</p>");
            stringBuilder.Append("<p><b>Nombre de place resérvée:</b>" + booking.SeatBooked + "</p>");
            stringBuilder.Append("<p><b>Prix:</b>" + booking.Projection.Price + "</p>");

            try
            {
                return Renderer.RenderHtmlAsPdf(stringBuilder.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return null;
            }
            
        }
    }
}
