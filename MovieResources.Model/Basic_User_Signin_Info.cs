using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.Model
{
    public class Basic_User_Signin_Info
    {
        public Guid Id { get; set; }
        public Guid User { get; set; }
        public DateTime Time { get; set; }
        public string IP { get; set; }
        public string Broswer { get; set; }
        public string Major_Version { get; set; }
        public string Position { get; set; }
    }
}
