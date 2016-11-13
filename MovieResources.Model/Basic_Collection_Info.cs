using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.Model
{
    public class Basic_Collection_Info
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid User { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        public string Cover { get; set; }
        public DateTime Create_Time { get; set; }
        public DateTime Alter_Time { get; set; }
    }
}
