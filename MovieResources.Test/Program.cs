using MovieResources.BLL;
using MovieResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic_User_Info info = new Basic_User_Info();
            //info.Id = Guid.NewGuid();
            //info.Account = "username1";
            //info.Password = "password1";
            //Console.Write(Basic_User_BLL.Insert(info));

            #region Celebrity
            //Basic_Celebrity_Info celeb = new Basic_Celebrity_Info();
            //celeb.Id = Guid.NewGuid();
            //celeb.Name = "按时发放";
            //Step_Celeb_Avatar_Info avatar = new Step_Celeb_Avatar_Info();
            //avatar.Id = Guid.NewGuid();
            //avatar.Celeb = celeb.Id;
            //avatar.Large = "asdfasfafa.jpg";
            //celeb.Avatar = avatar;
            //celeb.Create_User = Guid.Parse("652fb3b1-c17f-49c7-8d4c-4e2a1c21ea74");
            //Console.WriteLine(Basic_Celebrity_BLL.Insert(celeb));

            //Basic_Celebrity_Info celeb = Basic_Celebrity_BLL.GetSingle(Guid.Parse("E74BE854-F1F3-443D-A088-C56A310E0868"));
            //Console.ReadLine();

            //Dictionary<string, object> changes = new Dictionary<string, object>();
            //changes.Add("large", "safjajkhsfjasf.png");
            //changes.Add("douban", "13212354");
            //Basic_Celebrity_Info celeb = Basic_Celebrity_BLL.GetSingle(Guid.Parse("0C60A271-07BA-4127-A274-63E66348FE96"));
            //celeb.Avatar.Large = "asfasfasdawas.png";
            //celeb.Avatar.Small = "564r5q4r5qw.png";
            //changes.Add("avatar", celeb.Avatar);
            //Console.WriteLine(Basic_Celebrity_BLL.Update(Guid.Parse("0C60A271-07BA-4127-A274-63E66348FE96"), changes));

            //Console.WriteLine(Basic_Celebrity_BLL.Delete(Guid.Parse("E74BE854-F1F3-443D-A088-C56A310E0868")));
            #endregion

            #region Collection
            //Basic_Collection_Info info = new Basic_Collection_Info();
            //info.Id = Guid.NewGuid();
            //info.User = Guid.Parse("652fb3b1-c17f-49c7-8d4c-4e2a1c21ea74");
            //info.Cover = "asfafasfas.jpg";
            //info.Title = "sdewtwesdgsdgsdgs";
            //info.Content = "dzsgsdggggggggsg sdsdtegsdgs";
            //Console.Write(Basic_Collection_BLL.Insert(info));

            //Basic_Collection_Info celeb = Basic_Collection_BLL.GetSingle(Guid.Parse("0471956C-6786-4122-AB28-9CEE4D7F289E"));
            //Console.ReadLine();

            //Dictionary<string, object> changes = new Dictionary<string, object>();
            //changes.Add("cover", "safjajkhsfjasf.png");
            //changes.Add("title", "gagadsgsg");
            //Console.WriteLine(Basic_Collection_BLL.Update(Guid.Parse("0471956C-6786-4122-AB28-9CEE4D7F289E"), changes));

            //Console.WriteLine(Basic_Collection_BLL.Delete(Guid.Parse("E2E4E4DA-4041-4BE6-BAEA-E33892696EF2")));
            #endregion

            #region Movie
            //Basic_Movie_Info info = new Basic_Movie_Info();
            //info.Id = Guid.NewGuid();
            //info.Title = "啊手机发噶就是看";
            //info.Create_User = Guid.Parse("652fb3b1-c17f-49c7-8d4c-4e2a1c21ea74");
            //Step_Movie_Poster_Info poster = new Step_Movie_Poster_Info();
            //poster.Id = Guid.NewGuid();
            //poster.Movie = info.Id;
            //poster.Large = "asasfsaf.png";
            //info.Poster = poster;
            //Step_Movie_Rating_Info rating = new Step_Movie_Rating_Info();
            //rating.Id = Guid.NewGuid();
            //rating.Movie = info.Id;
            //rating.Score = 7.8;
            //info.Rating = rating;
            //List<Step_Movie_Country_Info> countries = new List<Step_Movie_Country_Info>();
            //countries.Add(new Step_Movie_Country_Info()
            //{
            //    Id = Guid.NewGuid(),
            //    Movie = info.Id,
            //    Country = "中国"
            //});
            //info.Country = countries;
            //List<Step_Movie_Genre_Info> genres = new List<Step_Movie_Genre_Info>();
            //genres.Add(new Step_Movie_Genre_Info()
            //{
            //    Id = Guid.NewGuid(),
            //    Movie = info.Id,
            //    Genre = "剧情"
            //});
            //info.Genre = genres;
            //List<Step_Movie_Lang_Info> langs = new List<Step_Movie_Lang_Info>();
            //langs.Add(new Step_Movie_Lang_Info()
            //{
            //    Id = Guid.NewGuid(),
            //    Movie = info.Id,
            //    Lang = "汉语"
            //});
            //info.Lang = langs;
            //Console.Write(Basic_Movie_BLL.Insert(info));

            //Dictionary<string, object> changes = new Dictionary<string, object>();
            //changes.Add("cover", "safjajkhsfjasf.png");
            //changes.Add("title", "gagadsgsg");
            //List<Step_Movie_Country_Info> countrychange = new List<Step_Movie_Country_Info>();
            //countrychange.Add(new Step_Movie_Country_Info()
            //{
            //    Id = Guid.NewGuid(),
            //    Movie = Guid.Parse("70D5848A-A823-4734-B63F-666395BA37FA"),
            //    Country = "法国"
            //});
            //changes.Add("country", countrychange);
            //Console.WriteLine(Basic_Movie_BLL.Update(Guid.Parse("70D5848A-A823-4734-B63F-666395BA37FA"), changes));

            //Console.WriteLine(Basic_Movie_BLL.Delete(Guid.Parse("70D5848A-A823-4734-B63F-666395BA37FA")));
            #endregion

            #region Recommend 
            //Basic_Recommend_Info info = new Basic_Recommend_Info();
            //info.Id = Guid.NewGuid();
            //info.Movie = Guid.Parse("1F7CEA4D-13D2-44D1-BEA4-E27AE77D7A9E");
            //info.Image = "asfafasfas.jpg";
            //info.Sort_Number = 654654564;
            //Console.Write(Basic_Recommend_BLL.Insert(info));

            //Basic_Recommend_Info recommend = Basic_Recommend_BLL.GetSingle(Guid.Parse("E08CF54E-0C38-4921-A9C5-8BDE99A435D0"));
            //Console.ReadLine();

            //Console.WriteLine(Basic_Recommend_BLL.Delete(Guid.Parse("E08CF54E-0C38-4921-A9C5-8BDE99A435D0")));
            #endregion

            #region Resource
            //Basic_Resource_Info info = new Basic_Resource_Info();
            //info.Id = Guid.NewGuid();
            //info.Movie = Guid.Parse("1F7CEA4D-13D2-44D1-BEA4-E27AE77D7A9E");
            //info.User = Guid.Parse("652FB3B1-C17F-49C7-8D4C-4E2A1C21EA74");
            //info.Title = "654654564";
            //Console.Write(Basic_Resource_BLL.Insert(info));

            //Basic_Resource_Info recommend = Basic_Resource_BLL.GetSingle(Guid.Parse("FF94FD01-78BA-4E63-AE7E-A8FA51048B2E"));
            //Console.ReadLine();

            //Console.WriteLine(Basic_Resource_BLL.Delete(Guid.Parse("FF94FD01-78BA-4E63-AE7E-A8FA51048B2E")));
            #endregion

            #region Request
            //Basic_Request_Info info = new Basic_Request_Info();
            //info.Id = Guid.NewGuid();
            //info.Movie = Guid.Parse("1F7CEA4D-13D2-44D1-BEA4-E27AE77D7A9E");
            //info.User = Guid.Parse("652FB3B1-C17F-49C7-8D4C-4E2A1C21EA74");
            //info.State = "待审核";
            //Console.Write(Basic_Request_BLL.Insert(info));

            //Basic_Request_Info recommend = Basic_Request_BLL.GetSingle(Guid.Parse("0B3002D3-EEF3-46DE-8126-4A7535D0261F"));
            //Console.ReadLine();

            //Dictionary<string, object> changes = new Dictionary<string, object>();
            //changes.Add("state", "未通过");
            //Console.WriteLine(Basic_Request_BLL.Update(Guid.Parse("0B3002D3-EEF3-46DE-8126-4A7535D0261F"), changes));


            //Console.WriteLine(Basic_Request_BLL.Delete(Guid.Parse("0B3002D3-EEF3-46DE-8126-4A7535D0261F")));
            #endregion

            #region Movie_Visit
            //Basic_Movie_Visit_Info info = new Basic_Movie_Visit_Info();
            //info.Id = Guid.NewGuid();
            //info.Movie = Guid.Parse("1F7CEA4D-13D2-44D1-BEA4-E27AE77D7A9E");
            //info.User = Guid.Parse("652FB3B1-C17F-49C7-8D4C-4E2A1C21EA74");
            //Console.Write(Basic_Movie_Visit_BLL.Insert(info));

            //Basic_Movie_Visit_Info recommend = Basic_Movie_Visit_BLL.GetSingle(Guid.Parse("B6F348CE-7C5F-4D1F-A0D7-DAF3A6508A9F"));
            //Console.ReadLine();

            //Console.WriteLine(Basic_Movie_Visit_BLL.Delete(Guid.Parse("B6F348CE-7C5F-4D1F-A0D7-DAF3A6508A9F")));
            #endregion


            #region User_Signin
            //Basic_User_Signin_Info info = new Basic_User_Signin_Info();
            //info.Id = Guid.NewGuid();
            //info.IP = "asdhqwh asklahfaf";
            //info.User = Guid.Parse("652FB3B1-C17F-49C7-8D4C-4E2A1C21EA74");
            //Console.Write(Basic_User_Signin_BLL.Insert(info));

            //Basic_User_Signin_Info recommend = Basic_User_Signin_BLL.GetSingle(Guid.Parse("484BFD82-777C-40FE-BD0D-B8E36A3884E9"));
            //Console.ReadLine();

            //Console.WriteLine(Basic_User_Signin_BLL.Delete(Guid.Parse("484BFD82-777C-40FE-BD0D-B8E36A3884E9")));
            #endregion
        }
    }
}
