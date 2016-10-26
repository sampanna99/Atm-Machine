using System.Web.Mvc;

namespace AutomatedTellerMaching.App_Start
{
    public class MyLoggingFilterAttribute : ActionFilterAttribute
    {
        //public override void OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    var request = filterContext.HttpContext.Request;
        //    Logger.logRequest(request.UserHostAddress); // video says logRequest is a custom method.
        //    base.OnActionExecuted(filterContext);
        //}
    }
}