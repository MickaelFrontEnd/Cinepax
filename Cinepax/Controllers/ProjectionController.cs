using System;
using System.Web.Mvc;
using Cinepax.Models;
using Cinepax.Services;
using Cinepax.ViewModel;

namespace Cinepax.Controllers
{
    public class ProjectionController : Controller
    {
        public ProjectionService projectionService = new ProjectionService();


        public ActionResult Index(string terms="", int page=1)
        {
            int totalResult = 0;

            ProjectionViewModel projectionViewModel = new ProjectionViewModel();

            projectionViewModel.Projections = projectionService.GetProjection(terms, page, out totalResult);
            projectionViewModel.TotalResult = (int)Math.Ceiling(((double)totalResult / 8));
            projectionViewModel.Page = page;
            projectionViewModel.Terms = terms;

            ViewBag.Title = "Maintenant dans nos salles de cinéma";

            return View(projectionViewModel);
        }

        public JsonResult GetProjection(int id)
        {
            Projection projection = projectionService.GetProjection(id);
            return Json (new {
                Title = projection.Movie.Name,
                Image = projection.Movie.Picture,
                Room = projection.Room.Name
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
