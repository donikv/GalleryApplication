﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryApplication.Models
{
    public class Picture
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        public List<Comment> Comments { get; set; }

    }
}
