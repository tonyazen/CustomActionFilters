using System;
using System.Web.Mvc;

namespace CustomActionFilters.Controllers
{
    public class HandleErrorAttributeController : Controller
    {
        [HandleError]
        public ActionResult Index()
        {
            throw new Exception("Oh no! Something went wrong!");
        }
    }
}