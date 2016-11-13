using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.Model
{
    public class Basic_Operation_Log_Info
    {
        public Guid Id { get; set; }

        public Guid Target { get; set; }

        public Guid User { get; set; }

        public DateTime Time { get; set; }

        public string Note { get; set; }
    }
}
