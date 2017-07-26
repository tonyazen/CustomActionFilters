using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomActionFilters.Controllers
{
    public class CustomFiltersController : Controller
    {
        // GET: CustomFilters
        public ActionResult Index()
        {
            return View();
        }
    }
}