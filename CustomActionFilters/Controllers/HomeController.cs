using CustomActionFilters.Filters;
using CustomActionFilters.Models;
using System.Web.Mvc;

namespace CustomActionFilters.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [CustomFilter]
        public ActionResult Contact()
        {
            var model = new ContactViewModel
            {
                Name = "Tonya Cooper",
                Location = "Grand Rapids, MI",
                TwitterHandle = "@tonyazen",
                Email = "cooper.tonya@gmail.com",
                ShowEmail = true
            };

            return View(model);
        }

        [CustomFilter]
        public ActionResult About()
        {
            return View();
        }
    }
}