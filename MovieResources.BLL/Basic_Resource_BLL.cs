using MovieResources.DAL;
using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.BLL
{
    public class Basic_Resource_BLL
    {
        public static Basic_Resource_Info GetSingle(Guid id)
        {
            Basic_Resource_DAL _Basic_Resource = new Basic_Resource_DAL();
            if (!_Basic_Resource.HasItem(id))
                return null;
            return _Basic_Resource.GetSingle(id);
        }

        public static bool Insert(Basic_Resource_Info info)
        {
            Basic_Resource_DAL _Basic_Resource = new Basic_Resource_DAL();

            if (info.Id == Guid.Empty)
                return false;
            return _Basic_Resource.Insert(info);
        }

        public static bool Update(Guid id, Dictionary<string, object> changes)
        {
            Basic_Resource_DAL _Basic_Resource = new Basic_Resource_DAL();
            if (!_Basic_Resource.HasItem(id))
                return false;
            return _Basic_Resource.Update(id, changes);
        }

        public static bool Delete(Guid id)
        {
            Basic_Resource_DAL _Basic_Resource = new Basic_Resource_DAL();
            if (!_Basic_Resource.HasItem(id))
                return false;
            return _Basic_Resource.Delete(id);
        }
    }
}
