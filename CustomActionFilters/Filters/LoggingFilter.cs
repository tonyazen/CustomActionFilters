using log4net;
using System.Web.Mvc;

namespace CustomActionFilters.Filters
{
    public class LoggingFilter : ActionFilterAttribute
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(LoggingFilter));

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _logger.Debug("CustomFilter: OnActionExecuting.");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            _logger.Debug("CustomFilter: OnActionExecuted.");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            _logger.Debug($"CustomFilter: OnResultExecuting.");
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            _logger.Debug("CustomFilter: OnResultExecuted.");
        }

    }
}