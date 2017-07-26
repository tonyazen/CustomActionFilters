using CustomActionFilters.Models;
using log4net;
using System.Web.Mvc;

namespace CustomActionFilters.Filters
{
    public class CustomFilter2 : ActionFilterAttribute
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(CustomFilter2));

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            _logger.Debug($"CustomFilter2: OnResultExecuting.");

            var model = (ContactViewModel)filterContext.Controller.ViewData.Model;
            model.ShowEmail = true;
        }

    }
}