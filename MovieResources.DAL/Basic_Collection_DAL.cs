using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.DAL
{
    public class Basic_Collection_DAL
    {
        #region 查
        public Basic_Collection_Info GetSingle(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                var result = database.Basic_Collection.FirstOrDefault(p => p.Id == id);

                return ToModel(result);
            }

        }

        public bool HasItem(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                return database.Basic_Collection.FirstOrDefault(p => p.Id == id) != null ? true : false;
            }
        }
        #endregion end查

        #region 增删改
        public bool Insert(Basic_Collection_Info info)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                try
                {
                    database.Basic_Collection.Add(ToDatabase(info));
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
                    var celeb = database.Basic_Collection.FirstOrDefault(p => p.Id == id);

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
                            case "summary":
                                celeb.Summary = (string)item.Value;
                                break;
                            case "cover":
                                celeb.Cover = (string)item.Value;
                                break;
                            case "altertime":
                                celeb.Alter_Time = (DateTime)item.Value;
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
                    var collect = database.Basic_Collection.FirstOrDefault(p => p.Id == id);
                    database.Basic_Collection.Remove(collect);
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

        public static Basic_Collection_Info ToModel(Basic_Collection collection)
        {
            Basic_Collection_Info info = new Basic_Collection_Info();

            info.Id = collection.Id;
            info.Title = collection.Title;
            info.User = (Guid)collection.User;
            info.Content = collection.Content;
            info.Summary = collection.Summary;
            info.Cover = collection.Cover;
            info.Create_Time = (DateTime)collection.Create_Time;
            info.Alter_Time = (DateTime)collection.Alter_Time;

            return info;
        }

        public static Basic_Collection ToDatabase(Basic_Collection_Info info)
        {
            Basic_Collection collection = new Basic_Collection();

            collection.Id = info.Id;
            collection.Title = info.Title;
            collection.User = info.User;
            collection.Content = info.Content;
            collection.Summary = info.Summary;
            collection.Alter_Time = info.Alter_Time;

            return collection;
        }
    }
}
