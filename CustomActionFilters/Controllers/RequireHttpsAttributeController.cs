using System.Web.Mvc;

namespace CustomActionFilters.Controllers
{
    public class RequireHttpsAttributeController : Controller
    {
        [HttpPost]
        [RequireHttps]
        public ActionResult SensitiveInformation()
        {
            return View();
        }
    }
}




