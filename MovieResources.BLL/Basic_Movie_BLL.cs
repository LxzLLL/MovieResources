using MovieResources.DAL;
using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.BLL
{
    public class Basic_Movie_BLL
    {
        public static Basic_Movie_Info GetSingle(Guid id)
        {
            Basic_Movie_DAL _Basic_Movie = new Basic_Movie_DAL();
            if (!_Basic_Movie.HasItem(id))
                return null;
            return _Basic_Movie.GetSingle(id);
        }

        public static bool Insert(Basic_Movie_Info info)
        {
            Basic_Movie_DAL _Basic_Movie = new Basic_Movie_DAL();

            if (info.Id == Guid.Empty)
                return false;
            return _Basic_Movie.Insert(info);
        }

        public static bool Update(Guid id, Dictionary<string, object> changes)
        {
            Basic_Movie_DAL _Basic_Movie = new Basic_Movie_DAL();
            if (!_Basic_Movie.HasItem(id))
                return false;
            return _Basic_Movie.Update(id, changes);
        }

        public static bool Delete(Guid id)
        {
            Basic_Movie_DAL _Basic_Movie = new Basic_Movie_DAL();
            if (!_Basic_Movie.HasItem(id))
                return false;
            return _Basic_Movie.Delete(id);
        }
    }
}
