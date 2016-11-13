using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.Model
{
    public class Basic_Movie_Info
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Title_En { get; set; }
        public string Aka { get; set; }
        public short Year { get; set; }
        public string Website { get; set; }
        public short Current_Season { get; set; }
        public short Season_Count { get; set; }
        public int Episode_Count { get; set; }
        public string Pubdate { get; set; }
        public string Duration { get; set; }
        public string Douban { get; set; }
        public string IMDb { get; set; }
        public string Summary { get; set; }
        public long Collect_Count { get; set; }
        public DateTime Create_Time { get; set; }
        public DateTime Alter_Time { get; set; }
        public Guid Create_User { get; set; }
        public virtual List<Step_Movie_Country_Info> Country { get; set; }
        public virtual List<Step_Movie_Genre_Info> Genre { get; set; }
        public virtual List<Step_Movie_Lang_Info> Lang { get; set; }
        public virtual Step_Movie_Poster_Info Poster { get; set; }
        public virtual Step_Movie_Rating_Info Rating { get; set; }
    }
}
