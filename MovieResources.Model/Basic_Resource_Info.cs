using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.Model
{
    public class Basic_Resource_Info
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Size { get; set; }
        public Guid User { get; set; }
        public Guid Movie { get; set; }
        public string Type { get; set; }
        public DateTime Time { get; set; }
        public string State { get; set; }
        public string Note { get; set; }
    }
}
