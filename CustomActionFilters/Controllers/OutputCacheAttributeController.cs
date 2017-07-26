using System.Web.Mvc;

namespace CustomActionFilters.Controllers
{
    public class OutputCacheAttributeController : Controller
    {
        [OutputCache(Duration = 600)]
        public ActionResult Index()
        {
            return View();
        }
    }
}


