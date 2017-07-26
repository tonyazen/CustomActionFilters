using System.Web.Mvc;

namespace CustomActionFilters.Controllers
{
    [Authorize]
    public class AuthorizeAttributeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        public ActionResult ManageUsers()
        {
            return View();
        }

        [Authorize(Users = "tonyazen")]
        public ActionResult ManageAdmins()
        {
            return View();
        }
    }
}






