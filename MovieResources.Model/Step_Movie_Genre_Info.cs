﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieResources.Model
{
    public class Step_Movie_Genre_Info
    {
        public Guid Id { get; set; }
        public Guid Movie { get; set; }
        public string Genre { get; set; }
    }
}
