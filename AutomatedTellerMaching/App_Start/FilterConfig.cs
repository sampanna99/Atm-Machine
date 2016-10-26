using AutomatedTellerMaching.App_Start;
using System.Web.Mvc;

namespace AutomatedTellerMaching
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new MyLoggingFilterAttribute());
        }
    }
}
