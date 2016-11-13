using MovieResources.DAL;
using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.BLL
{
    public class Basic_Collection_BLL
    {
        public static Basic_Collection_Info GetSingle(Guid id)
        {
            Basic_Collection_DAL _Basic_Collection = new Basic_Collection_DAL();
            if (!_Basic_Collection.HasItem(id))
                return null;
            return _Basic_Collection.GetSingle(id);
        }

        public static bool Insert(Basic_Collection_Info info)
        {
            Basic_Collection_DAL _Basic_Collection = new Basic_Collection_DAL();

            if (info.Id == Guid.Empty)
                return false;
            return _Basic_Collection.Insert(info);
        }

        public static bool Update(Guid id, Dictionary<string, object> changes)
        {
            Basic_Collection_DAL _Basic_Collection = new Basic_Collection_DAL();
            if (!_Basic_Collection.HasItem(id))
                return false;
            return _Basic_Collection.Update(id, changes);
        }

        public static bool Delete(Guid id)
        {
            Basic_Collection_DAL _Basic_Collection = new Basic_Collection_DAL();
            if (!_Basic_Collection.HasItem(id))
                return false;
            return _Basic_Collection.Delete(id);
        }
    }
}
