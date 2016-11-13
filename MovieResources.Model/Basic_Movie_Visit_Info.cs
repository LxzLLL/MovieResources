using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.Model
{
    public class Basic_Movie_Visit_Info
    {
        public Guid Id { get; set; }
        public Guid Movie { get; set; }
        public Guid User { get; set; }
        public DateTime Time { get; set; }
    }
}
