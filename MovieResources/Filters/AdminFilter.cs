using MovieResources.Helpers;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieResources.Filters
{

    /// <summary>
    /// 表示一个特性，该特性用于限制操作方法，以便该方法只处理管理员的请求
    /// </summary>
    public class AdministratorAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //MR_DataClassesDataContext _db = new MR_DataClassesDataContext();
            //MRDataEntities _db = new MRDataEntities();
            //if (string.IsNullOrEmpty(filterContext.HttpContext.CookieHepler.GetCookie("user")) || string.IsNullOrWhiteSpace(filterContext.HttpContext.CookieHepler.GetCookie("user")))
            //{
            //    filterContext.Result = new RedirectResult("/Account/Login");
            //    return;
            //}
            //if (!(bool)_db.tbl_UserAccount.Single(m => m.user_Account == filterContext.HttpContext.CookieHepler.GetCookie("user")).user_IsAdmin)
            //{
            //    filterContext.Result = new RedirectResult("/Error/NotAdmin");
            //}

            if (HttpContext.Current.Request.Cookies["usertype"] == null || !bool.Parse(HttpContext.Current.Request.Cookies["usertype"].Value))
            {
                filterContext.Result = new RedirectResult("/Error/NotAdmin");
            }
        }
    }


    public class SignedinAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!CookieHepler.HasCookie("user"))// HttpContext.Current.Request.Cookies["User"] != null && !string.IsNullOrEmpty(HttpContext.Current.Request.Cookies["User"].Value))
            {
                filterContext.Result = new RedirectResult("/Account/Login");
            }
        }
    }
}