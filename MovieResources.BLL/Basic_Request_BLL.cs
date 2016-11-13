using MovieResources.DAL;
using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.BLL
{
    public class Basic_Request_BLL
    {
        public static Basic_Request_Info GetSingle(Guid id)
        {
            Basic_Request_DAL _Basic_Request = new Basic_Request_DAL();
            if (!_Basic_Request.HasItem(id))
                return null;
            return _Basic_Request.GetSingle(id);
        }

        public static bool Insert(Basic_Request_Info info)
        {
            Basic_Request_DAL _Basic_Request = new Basic_Request_DAL();

            if (info.Id == Guid.Empty)
                return false;
            return _Basic_Request.Insert(info);
        }

        public static bool Update(Guid id, Dictionary<string, object> changes)
        {
            Basic_Request_DAL _Basic_Request = new Basic_Request_DAL();
            if (!_Basic_Request.HasItem(id))
                return false;
            return _Basic_Request.Update(id, changes);
        }

        public static bool Delete(Guid id)
        {
            Basic_Request_DAL _Basic_Request = new Basic_Request_DAL();
            if (!_Basic_Request.HasItem(id))
                return false;
            return _Basic_Request.Delete(id);
        }
    }
}
