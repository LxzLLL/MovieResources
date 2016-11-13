using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.Model
{
    public class Basic_Celebrity_Info
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Aka { get; set; }
        public string Name_En { get; set; }
        public string Aka_En { get; set; }
        public bool Gender { get; set; }
        public string Profession { get; set; }
        public string Birth_Date { get; set; }
        public string Death_Date { get; set; }
        public string Born_Place { get; set; }
        public string Family { get; set; }
        public string Douban { get; set; }
        public string IMDb { get; set; }
        public string Summary { get; set; }
        public DateTime Create_Time { get; set; }
        public DateTime Alter_Time { get; set; }
        public Guid Create_User { get; set; }
        public Step_Celeb_Avatar_Info Avatar { get; set; }
    }
}
