using System.Web;
using System.Web.Mvc;
using CustomActionFilters.Filters;

namespace CustomActionFilters
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new RedirectToContactFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}


