using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.DAL
{
    /// <summary>
    /// 对数据库表Basic_User的操作类
    /// </summary>
    public class Basic_User_DAL
    {
        #region 查
        /// <summary>
        /// 根据id获取一项User信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        public Basic_User_Info GetSingle(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                var result = database.Basic_User.FirstOrDefault(p => p.Id == id);

                return ToModel(result);
            }

        }

        /// <summary>
        /// 根据account获取一项User信息
        /// </summary>
        /// <param name="account">用户名</param>
        /// <returns></returns>
        public Basic_User_Info GetSingleByAccount(string account)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                var result = database.Basic_User.FirstOrDefault(p => p.Account == account);
                if (result == null)
                    return null;
                else
                    return ToModel(result);
            }
        }

        /// <summary>
        /// 根据提供的sql语句从Basic_User返回查询结果
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">sql参数</param>
        /// <returns></returns>
        public List<Basic_User_Info> GetList(string sql, params object[] parameters)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                var result = database.Basic_User.SqlQuery("select * from Basic_User where ", parameters);
                List<Basic_User_Info> infos = new List<Basic_User_Info>();
                foreach (var item in result)
                {
                    infos.Add(ToModel(item));
                }
                return infos;
            }

        }

        /// <summary>
        /// 判断Basic_User中是否存在一项
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        public bool HasItem(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                System.Diagnostics.Debug.WriteLine(database.Basic_User.FirstOrDefault(p => p.Id == id).Account);
                return database.Basic_User.FirstOrDefault(p => p.Id == id) != null ? true : false;
            }
        }
        #endregion

        #region 增删改
        /// <summary>
        /// 向Basic_User中插入一条数据
        /// </summary>
        /// <param name="info"></param>
        /// <returns>是否插入成功</returns>
        public bool Insert(Basic_User_Info info)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                try
                {
                    database.Basic_User.Add(ToDatabase(info));
                    database.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 更新Basic_User中的一条数据
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="changes">要更新的值，可以包括多个键值对</param>
        /// <returns>是否更新成功</returns>
        public bool Update(Guid id, Dictionary<string, string> changes)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                try
                {
                    Basic_User user = database.Basic_User.FirstOrDefault(p => p.Id == id);

                    foreach (var item in changes)
                    {
                        switch (item.Key)
                        {
                            case "password":
                                user.Password = item.Value;
                                break;
                            case "avatar":
                                user.Avatar = item.Value;
                                break;
                            case "cover":
                                user.Cover = item.Value;
                                break;
                            case "limit":
                                user.Limit = bool.Parse(item.Value);
                                break;
                            case "email":
                                user.Email = item.Value;
                                break;
                            case "phone":
                                user.Phone_Number = item.Value;
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


        /// <summary>
        /// 从Basic_User中删除一条数据
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns>是否删除成功</returns>
        public bool Delete(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                try
                {
                    Basic_User user = database.Basic_User.FirstOrDefault(p => p.Id == id);
                    database.Basic_User.Remove(user);
                    database.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        /// <summary>
        /// 数据库表Basic_User转化为Model类Basic_User_Info
        /// </summary>
        /// <param name="user">要转化的Model类Basic_User</param>
        /// <returns>转化后的数据库表Basic_User_Info</returns>
        private Basic_User_Info ToModel(Basic_User user)
        {
            Basic_User_Info info = new Basic_User_Info();

            info.Id = user.Id;
            info.Account = user.Account;
            info.Password = user.Password;
            info.Avatar = user.Avatar;
            info.Cover = user.Cover;
            info.Limit = (bool)user.Limit;
            info.Email = user.Email;
            info.Phone_Number = user.Phone_Number;

            return info;
        }

        /// <summary>
        /// Model类Basic_User_Info转化为数据库表Basic_User
        /// </summary>
        /// <param name="info">要转化的Model类Basic_User_Info</param>
        /// <returns>转化后的数据库表Basic_User</returns>
        private Basic_User ToDatabase(Basic_User_Info info)
        {
            Basic_User user = new Basic_User();

            user.Id = info.Id;
            user.Account = info.Account;
            user.Password = info.Password;
            user.Avatar = info.Avatar;
            user.Cover = info.Cover;
            user.Limit = info.Limit;
            user.Email = info.Email;
            user.Phone_Number = info.Phone_Number;

            return user;
        }
    }
}
