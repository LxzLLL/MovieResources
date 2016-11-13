using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.DAL
{
    public class Basic_Resource_DAL
    {
        #region 查
        public Basic_Resource_Info GetSingle(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                var result = database.Basic_Resource.FirstOrDefault(p => p.Id == id);

                return ToModel(result);
            }

        }

        public bool HasItem(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                return database.Basic_Resource.FirstOrDefault(p => p.Id == id) != null ? true : false;
            }
        }
        #endregion end查

        #region 增删改
        public bool Insert(Basic_Resource_Info info)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                try
                {
                    database.Basic_Resource.Add(ToDatabase(info));
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
                    var celeb = database.Basic_Resource.FirstOrDefault(p => p.Id == id);

                    foreach (var item in changes)
                    {
                        switch (item.Key)
                        {
                            case "title":
                                celeb.Title = (string)item.Value;
                                break;
                            case "content":
                                celeb.Content = (string)item.Value;
                                break;
                            case "type":
                                celeb.Type = (string)item.Value;
                                break;
                            case "size":
                                celeb.Size = (string)item.Value;
                                break;
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
                    var resource = database.Basic_Resource.FirstOrDefault(p => p.Id == id);
                    database.Basic_Resource.Remove(resource);
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

        public static Basic_Resource_Info ToModel(Basic_Resource resource)
        {
            Basic_Resource_Info info = new Basic_Resource_Info();

            info.Id = resource.Id;
            info.User = (Guid)resource.User;
            info.Movie = (Guid)resource.Movie;
            info.Title = resource.Title;
            info.Content = resource.Content;
            info.Type = resource.Type;
            info.Size = resource.Size;
            info.State = resource.State;
            info.Note = resource.Note;
            info.Time = (DateTime)resource.Time;

            return info;
        }

        public static Basic_Resource ToDatabase(Basic_Resource_Info info)
        {
            Basic_Resource resource = new Basic_Resource();

            resource.Id = info.Id;
            resource.User = info.User;
            resource.Movie = info.Movie;
            resource.Title = info.Title;
            resource.Content = info.Content;
            resource.Type = info.Type;
            resource.Size = info.Size;
            resource.State = info.State;
            resource.Note = info.Note;
            resource.Time = info.Time;

            return resource;
        }
    }
}
