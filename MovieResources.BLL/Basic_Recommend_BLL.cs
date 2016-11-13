using MovieResources.DAL;
using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.BLL
{
    public class Basic_Recommend_BLL
    {
        public static Basic_Recommend_Info GetSingle(Guid id)
        {
            Basic_Recommend_DAL _Basic_Recommend = new Basic_Recommend_DAL();
            if (!_Basic_Recommend.HasItem(id))
                return null;
            return _Basic_Recommend.GetSingle(id);
        }

        public static bool Insert(Basic_Recommend_Info info)
        {
            Basic_Recommend_DAL _Basic_Recommend = new Basic_Recommend_DAL();

            if (info.Id == Guid.Empty)
                return false;
            return _Basic_Recommend.Insert(info);
        }

        //public static bool Update(Guid id, Dictionary<string, object> changes)
        //{
        //    Basic_Recommend_DAL _Basic_Collection = new Basic_Recommend_DAL();
        //    if (!_Basic_Collection.HasItem(id))
        //        return false;
        //    return _Basic_Collection.Update(id, changes);
        //}

        public static bool Delete(Guid id)
        {
            Basic_Recommend_DAL _Basic_Recommend = new Basic_Recommend_DAL();
            if (!_Basic_Recommend.HasItem(id))
                return false;
            return _Basic_Recommend.Delete(id);
        }
    }
}
