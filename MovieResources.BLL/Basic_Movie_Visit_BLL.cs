using MovieResources.DAL;
using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.BLL
{
    public class Basic_Movie_Visit_BLL
    {
        public static Basic_Movie_Visit_Info GetSingle(Guid id)
        {
            Basic_Movie_Visit_DAL _Basic_Movie_Visit = new Basic_Movie_Visit_DAL();
            if (!_Basic_Movie_Visit.HasItem(id))
                return null;
            return _Basic_Movie_Visit.GetSingle(id);
        }

        public static bool Insert(Basic_Movie_Visit_Info info)
        {
            Basic_Movie_Visit_DAL _Basic_Movie_Visit = new Basic_Movie_Visit_DAL();

            if (info.Id == Guid.Empty)
                return false;
            return _Basic_Movie_Visit.Insert(info);
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
            Basic_Movie_Visit_DAL _Basic_Movie_Visit = new Basic_Movie_Visit_DAL();
            if (!_Basic_Movie_Visit.HasItem(id))
                return false;
            return _Basic_Movie_Visit.Delete(id);
        }
    }
}
