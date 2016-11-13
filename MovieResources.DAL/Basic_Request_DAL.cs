using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.DAL
{
    public class Basic_Request_DAL
    {
        #region 查
        public Basic_Request_Info GetSingle(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                var result = database.Basic_Request.FirstOrDefault(p => p.Id == id);

                return ToModel(result);
            }

        }

        public bool HasItem(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                return database.Basic_Request.FirstOrDefault(p => p.Id == id) != null ? true : false;
            }
        }
        #endregion end查

        #region 增删改
        public bool Insert(Basic_Request_Info info)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                try
                {
                    database.Basic_Request.Add(ToDatabase(info));
                    database.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public bool Update(Guid id, Dictionary<string, object> changes)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                try
                {
                    var celeb = database.Basic_Request.FirstOrDefault(p => p.Id == id);

                    foreach (var item in changes)
                    {
                        switch (item.Key)
                        {
                            case "state":
                                celeb.State = (string)item.Value;
                                break;
                            case "note":
                                celeb.Note = (string)item.Value;
                                break;
                            default: break;
                        }
                    }
                    database.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool Delete(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                try
                {
                    var resource = database.Basic_Request.FirstOrDefault(p => p.Id == id);
                    database.Basic_Request.Remove(resource);
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

        public static Basic_Request_Info ToModel(Basic_Request resource)
        {
            Basic_Request_Info info = new Basic_Request_Info();

            info.Id = resource.Id;
            info.User = (Guid)resource.User;
            info.Movie = (Guid)resource.Movie;
            info.State = resource.State;
            info.Note = resource.Note;
            info.Time = (DateTime)resource.Time;

            return info;
        }

        public static Basic_Request ToDatabase(Basic_Request_Info info)
        {
            Basic_Request resource = new Basic_Request();

            resource.Id = info.Id;
            resource.User = info.User;
            resource.Movie = info.Movie;
            resource.State = info.State;
            resource.Note = info.Note;
            resource.Time = info.Time;

            return resource;
        }
    }
}
