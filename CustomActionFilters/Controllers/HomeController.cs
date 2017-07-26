using System.Web.Mvc;

namespace CustomActionFilters.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="admin")]
        public ActionResult ManageUsers()
        {
            return View();
        }

        [Authorize(Users ="tonyazen")]
        public ActionResult About()
        {
            return View();
        }
    }
}