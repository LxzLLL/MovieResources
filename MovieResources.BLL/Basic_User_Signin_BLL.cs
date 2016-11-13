using MovieResources.DAL;
using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.BLL
{
    public class Basic_User_Signin_BLL
    {
        public static Basic_User_Signin_Info GetSingle(Guid id)
        {
            Basic_User_Signin_DAL _Basic_User_Signin = new Basic_User_Signin_DAL();
            if (!_Basic_User_Signin.HasItem(id))
                return null;
            return _Basic_User_Signin.GetSingle(id);
        }

        public static bool Insert(Basic_User_Signin_Info info)
        {
            Basic_User_Signin_DAL _Basic_User_Signin = new Basic_User_Signin_DAL();

            if (info.Id == Guid.Empty)
                return false;
            return _Basic_User_Signin.Insert(info);
        }

        //public static bool Update(Guid id, Dictionary<string, object> changes)
        //{
        //    Basic_Movie_Visit _Basic_Resource = new Basic_Movie_Visit();
        //    if (!_Basic_Resource.HasItem(id))
        //        return false;
        //    return _Basic_Resource.Update(id, changes);
        //}

        public static bool Delete(Guid id)
        {
            Basic_User_Signin_DAL _Basic_User_Signin = new Basic_User_Signin_DAL();
            if (!_Basic_User_Signin.HasItem(id))
                return false;
            return _Basic_User_Signin.Delete(id);
        }
    }
}
