using System.Linq;
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
            MRDataEntities _db = new MRDataEntities();
            if (string.IsNullOrEmpty(filterContext.HttpContext.User.Identity.Name) || string.IsNullOrWhiteSpace(filterContext.HttpContext.User.Identity.Name))
            {
                filterContext.Result = new RedirectResult("/Account/Login");
                return;
            }
            if (!(bool)_db.tbl_UserAccount.Single(m => m.user_Account == filterContext.HttpContext.User.Identity.Name).user_IsAdmin)
            {
                filterContext.Result = new RedirectResult("/Error/NotAdmin");
            }
        }
    }
}