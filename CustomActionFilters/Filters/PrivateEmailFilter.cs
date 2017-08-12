using CustomActionFilters.Models;
using System.Web.Mvc;

namespace CustomActionFilters.Filters
{
    public class PrivateEmailFilter : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var model = (ContactViewModel)filterContext.Controller.ViewData.Model;
            model.ShowEmail = false;

            filterContext.Controller.ViewBag.Message = "Email is private.";
        }
    }
}