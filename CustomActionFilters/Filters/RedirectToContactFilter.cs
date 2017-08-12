using System.Web.Mvc;
using System.Web.Routing;

namespace CustomActionFilters.Filters
{
    public class RedirectToContactFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.ActionDescriptor.ActionName == "About")
                RedirectToContactPage(filterContext);
        }

        private void RedirectToContactPage(ActionExecutingContext actionExecutingContext)
        {
            actionExecutingContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary
                {
                    {"controller", "Home"},
                    {"action", "Contact" }
                });
        }

    }
}