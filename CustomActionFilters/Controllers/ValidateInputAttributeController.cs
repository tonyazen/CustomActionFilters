using CustomActionFilters.Models;
using System.Web.Mvc;

namespace CustomActionFilters.Controllers
{
    public class ValidateInputAttributeController : Controller
    {
        [HttpGet]
        public ActionResult MyForm()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult MyForm(MyFormViewModel model)
        {
            return View();
        }
    }
}




