using CustomActionFilters.Filters;
using CustomActionFilters.Models;
using System.Web.Mvc;

namespace CustomActionFilters.Controllers
{
    public class HomeController : Controller
    {
        [LoggingFilter]
        public ActionResult Index()
        {
            return View();
        }

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

        [RedirectToContactFilter]
        public ActionResult About()
        {
            return View();
        }
    }
}