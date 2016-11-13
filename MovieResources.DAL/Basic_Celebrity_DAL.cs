﻿using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.DAL
{
    public class Basic_Celebrity_DAL
    {
        #region 查
        public Basic_Celebrity_Info GetSingle(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                var result = database.Basic_Celebrity.FirstOrDefault(p => p.Id == id);

                return ToModel(result);
            }

        }

        public bool HasItem(Guid id)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                return database.Basic_Celebrity.FirstOrDefault(p => p.Id == id) != null ? true : false;
            }
        }
        #endregion end查

        #region 增删改
        public bool Insert(Basic_Celebrity_Info info)
        {
            using (MovieResShareEntities database = new MovieResShareEntities())
            {
                try
                {
                    database.Basic_Celebrity.Add(ToDatabase(info));
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
                    var celeb = database.Basic_Celebrity.FirstOrDefault(p => p.Id == id);

                    foreach (var item in changes)
                    {
                        switch (item.Key)
                        {
                            case "name":
                                celeb.Name = (string)item.Value;
                                break;
                            case "nameen":
                                celeb.Name_En = (string)item.Value;
                                break;
                            case "aka":
                                celeb.Aka = (string)item.Value;
                                break;
                            case "akaen":
                                celeb.Aka_En = (string)item.Value;
                                break;
                            case "gender":
                                celeb.Gender = (bool)item.Value;
                                break;
                            case "profession":
                                celeb.Profession = (string)item.Value;
                                break;
                            case "birthdate":
                                celeb.Birth_Date = (string)item.Value;
                                break;
                            case "deathdate":
                                celeb.Death_Date = (string)item.Value;
                                break;
                            case "bornplace":
                                celeb.Profession = (string)item.Value;
                                break;
                            case "family":
                                celeb.Family = (string)item.Value;
                                break;
                            case "douban":
                                celeb.Douban = (string)item.Value;
                                break;
                            case "imdb":
                                celeb.IMDb = (string)item.Value;
                                break;
                            case "summary":
                                celeb.Summary = (string)item.Value;
                                break;
                            case "altertime":
                                celeb.Alter_Time = (DateTime)item.Value;
                                break;
                            case "avatar":
                                celeb.Step_Celeb_Avatar.FirstOrDefault().Large = ((Step_Celeb_Avatar_Info)item.Value).Large;
                                celeb.Step_Celeb_Avatar.FirstOrDefault().Small = ((Step_Celeb_Avatar_Info)item.Value).Small;
                                celeb.Step_Celeb_Avatar.FirstOrDefault().Medium = ((Step_Celeb_Avatar_Info)item.Value).Medium;
                                break;
                            default: break;
                        }
                    }
                    database.SaveChanges();
                    return true;
                }
                catch (Exception e)
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
                    Basic_Celebrity celeb = database.Basic_Celebrity.FirstOrDefault(p => p.Id == id);
                    Step_Celeb_Avatar avatar = database.Step_Celeb_Avatar.FirstOrDefault(p => p.Celeb == id);
                    database.Basic_Celebrity.Remove(celeb);
                    database.Step_Celeb_Avatar.Remove(avatar);
                    database.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
        #endregion end增删改

        public static Basic_Celebrity_Info ToModel(Basic_Celebrity celeb)
        {
            Basic_Celebrity_Info info = new Basic_Celebrity_Info();

            info.Id = celeb.Id;
            info.Name = celeb.Name;
            info.Aka = celeb.Aka;
            info.Name_En = celeb.Name_En;
            info.Aka_En = celeb.Aka_En;
            info.Gender = (bool)celeb.Gender;
            info.Profession = celeb.Profession;
            info.Birth_Date = celeb.Birth_Date;
            info.Death_Date = celeb.Death_Date;
            info.Born_Place = celeb.Born_Place;
            info.Family = celeb.Family;
            info.Douban = celeb.Douban;
            info.IMDb = celeb.IMDb;
            info.Summary = celeb.Summary;
            info.Create_Time = (DateTime)celeb.Create_Time;
            info.Alter_Time = (DateTime)celeb.Alter_Time;
            info.Create_User = (Guid)celeb.Create_User;
            info.Avatar = Step_Celeb_Avatar_DAL.ToModel(celeb.Step_Celeb_Avatar.FirstOrDefault());

            return info;
        }

        public static Basic_Celebrity ToDatabase(Basic_Celebrity_Info info)
        {
            Basic_Celebrity celeb = new Basic_Celebrity();

            celeb.Id = info.Id;
            celeb.Name = info.Name;
            celeb.Aka = info.Aka;
            celeb.Name_En = info.Name_En;
            celeb.Aka_En = info.Aka_En;
            celeb.Gender = info.Gender;
            celeb.Profession = info.Profession;
            celeb.Birth_Date = info.Birth_Date;
            celeb.Death_Date = info.Death_Date;
            celeb.Born_Place = info.Born_Place;
            celeb.Family = info.Family;
            celeb.Douban = info.Douban;
            celeb.IMDb = info.IMDb;
            celeb.Summary = info.Summary;
            celeb.Create_Time = info.Create_Time;
            celeb.Alter_Time = info.Alter_Time;
            celeb.Create_User = info.Create_User;

            List<Step_Celeb_Avatar> avatar = new List<Step_Celeb_Avatar>();
            avatar.Add(new Step_Celeb_Avatar()
            {
                Id = info.Avatar.Id,
                Celeb = info.Avatar.Celeb,
                Large = info.Avatar.Large,
                Medium = info.Avatar.Medium,
                Small = info.Avatar.Small
            });
            celeb.Step_Celeb_Avatar = avatar;

            return celeb;
        }
    }
}
