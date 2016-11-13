using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.DAL
{
    public class Basic_Movie_Visit_DAL
    {
        #region 查
        public Basic_Movie_Visit_Info GetSingle(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                var result = database.Basic_Movie_Visit.FirstOrDefault(p => p.Id == id);

                return ToModel(result);
            }

        }

        public bool HasItem(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                return database.Basic_Movie_Visit.FirstOrDefault(p => p.Id == id) != null ? true : false;
            }
        }
        #endregion end查

        #region 增删改
        public bool Insert(Basic_Movie_Visit_Info info)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                try
                {
                    database.Basic_Movie_Visit.Add(ToDatabase(info));
                    database.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        //public bool Update(Guid id, Dictionary<string, object> changes)
        //{
        //    using (MovieResShareEntities database = new MovieResShareEntities())
        //    {
        //        try
        //        {
        //            var celeb = database.Basic_Movie_Visit.FirstOrDefault(p => p.Id == id);

        //            foreach (var item in changes)
        //            {
        //                switch (item.Key)
        //                {
        //                    case "state":
        //                        celeb.State = (string)item.Value;
        //                        break;
        //                    case "note":
        //                        celeb.Note = (string)item.Value;
        //                        break;
        //                    default: break;
        //                }
        //            }
        //            database.SaveChanges();
        //            return true;
        //        }
        //        catch (Exception)
        //        {
        //            return false;
        //        }
        //    }
        //}

        public bool Delete(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                try
                {
                    var visit = database.Basic_Movie_Visit.FirstOrDefault(p => p.Id == id);
                    database.Basic_Movie_Visit.Remove(visit);
                    database.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion end增删改

        public static Basic_Movie_Visit_Info ToModel(Basic_Movie_Visit visit)
        {
            Basic_Movie_Visit_Info info = new Basic_Movie_Visit_Info();

            info.Id = visit.Id;
            info.User = (Guid)visit.User;
            info.Movie = (Guid)visit.Movie;
            info.Time = (DateTime)visit.Time;

            return info;
        }

        public static Basic_Movie_Visit ToDatabase(Basic_Movie_Visit_Info info)
        {
            Basic_Movie_Visit visit = new Basic_Movie_Visit();

            visit.Id = info.Id;
            visit.User = info.User;
            visit.Movie = info.Movie;
            visit.Time = info.Time;

            return visit;
        }
    }
}
