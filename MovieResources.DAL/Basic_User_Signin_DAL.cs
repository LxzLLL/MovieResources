using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.DAL
{
    public class Basic_User_Signin_DAL
    {
        #region 查
        public Basic_User_Signin_Info GetSingle(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                var result = database.Basic_User_Signin.FirstOrDefault(p => p.Id == id);

                return ToModel(result);
            }

        }

        public bool HasItem(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                return database.Basic_User_Signin.FirstOrDefault(p => p.Id == id) != null ? true : false;
            }
        }
        #endregion end查

        #region 增删改
        public bool Insert(Basic_User_Signin_Info info)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                try
                {
                    database.Basic_User_Signin.Add(ToDatabase(info));
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
                    var sigin = database.Basic_User_Signin.FirstOrDefault(p => p.Id == id);
                    database.Basic_User_Signin.Remove(sigin);
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

        public static Basic_User_Signin_Info ToModel(Basic_User_Signin sigin)
        {
            Basic_User_Signin_Info info = new Basic_User_Signin_Info();

            info.Id = sigin.Id;
            info.User = (Guid)sigin.User;
            info.IP = sigin.IP;
            info.Time = (DateTime)sigin.Time;
            info.Broswer = sigin.Broswer;
            info.Major_Version = sigin.Major_Version;
            info.Position = sigin.Position;

            return info;
        }

        public static Basic_User_Signin ToDatabase(Basic_User_Signin_Info info)
        {
            Basic_User_Signin sigin = new Basic_User_Signin();

            sigin.Id = info.Id;
            sigin.User = info.User;
            sigin.IP = info.IP;
            sigin.Time = info.Time;
            sigin.Broswer = info.Broswer;
            sigin.Major_Version = info.Major_Version;
            sigin.Position = info.Position;

            return sigin;
        }
    }
}
