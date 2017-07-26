using System.Web.Mvc;
using System.Web.Routing;
using log4net;
using CustomActionFilters.Models;

namespace CustomActionFilters.Filters
{
    public class CustomFilter : ActionFilterAttribute
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(CustomFilter));

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _logger.Debug("CustomFilter: OnActionExecuting.");

            if (filterContext.ActionDescriptor.ActionName == "About")
                RedirectToContact(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            _logger.Debug("CustomFilter: OnActionExecuted.");

        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            _logger.Debug($"CustomFilter: OnResultExecuting.");

            //var model = (ContactViewModel)filterContext.Controller.ViewData.Model;
            //model.ShowEmail = false;

            //filterContext.Controller.ViewBag.Message += " This page has been filtered.";
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            _logger.Debug("CustomFilter: OnResultExecuted.");
        }

        private void RedirectToContact(ActionExecutingContext actionExecutingContext)
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