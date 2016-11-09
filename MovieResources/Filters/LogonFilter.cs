using System.Web;
using System.Web.Mvc;
using MovieResources.Helpers;

namespace MovieResources.Filters
{
    public class LogonFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //if (HttpContext.Current.User.Identity.IsAuthenticated)
            if (!CookieHepler.HasValue("user"))// HttpContext.Current.Request.Cookies["User"] != null && !string.IsNullOrEmpty(HttpContext.Current.Request.Cookies["User"].Value))
            {
                filterContext.Result = new RedirectResult("/Mine/Index");
            }
        }
    }
}