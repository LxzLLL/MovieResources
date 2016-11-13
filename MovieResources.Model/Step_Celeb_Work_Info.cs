using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.Model
{
    public class Step_Celeb_Work_Info
    {
        public Guid Id { get; set; }
        public Guid Movie { get; set; }
        public Guid Celeb { get; set; }
        public string Position { get; set; }
    }
}
