using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.DAL
{
    public class Basic_Recommend_DAL
    {
        #region 查
        public Basic_Recommend_Info GetSingle(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                var result = database.Basic_Recommend.FirstOrDefault(p => p.Id == id);

                return ToModel(result);
            }

        }

        public bool HasItem(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                return database.Basic_Recommend.FirstOrDefault(p => p.Id == id) != null ? true : false;
            }
        }
        #endregion end查

        #region 增删改
        public bool Insert(Basic_Recommend_Info info)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                try
                {
                    database.Basic_Recommend.Add(ToDatabase(info));
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
        //            var celeb = database.Basic_Recommend.FirstOrDefault(p => p.Id == id);

        //            foreach (var item in changes)
        //            {
        //                switch (item.Key)
        //                {
        //                    case "title":
        //                        celeb.Title = (string)item.Value;
        //                        break;
        //                    case "content":
        //                        celeb.Content = (string)item.Value;
        //                        break;
        //                    case "summary":
        //                        celeb.Summary = (string)item.Value;
        //                        break;
        //                    case "cover":
        //                        celeb.Cover = (string)item.Value;
        //                        break;
        //                    case "altertime":
        //                        celeb.Alter_Time = (DateTime)item.Value;
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
                    var recommend = database.Basic_Recommend.FirstOrDefault(p => p.Id == id);
                    database.Basic_Recommend.Remove(recommend);
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

        public static Basic_Recommend_Info ToModel(Basic_Recommend recommend)
        {
            Basic_Recommend_Info info = new Basic_Recommend_Info();

            info.Id = recommend.Id;
            info.Image = recommend.Image;
            info.Movie = (Guid)recommend.Movie;

            return info;
        }

        public static Basic_Recommend ToDatabase(Basic_Recommend_Info info)
        {
            Basic_Recommend recommend = new Basic_Recommend();

            recommend.Id = info.Id;
            recommend.Image = info.Image;
            recommend.Movie = info.Movie;
            recommend.Sort_Number = info.Sort_Number;

            return recommend;
        }
    }
}
