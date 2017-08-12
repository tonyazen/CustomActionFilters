using log4net;
using System.Web.Mvc;

namespace CustomActionFilters.Filters
{
    public class LoggingFilter : ActionFilterAttribute
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(LoggingFilter));

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _logger.Debug("1.");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            _logger.Debug("2.");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            _logger.Debug("3.");
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            _logger.Debug("4.");
        }

    }
}