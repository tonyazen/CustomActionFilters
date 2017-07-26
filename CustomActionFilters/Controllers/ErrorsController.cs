using System.Web.Mvc;

namespace CustomActionFilters.Controllers
{
    public class ErrorsController : Controller
    {
        // GET: Errors
        public ActionResult PageNotFound()
        {
            return View();
        }
    }
}