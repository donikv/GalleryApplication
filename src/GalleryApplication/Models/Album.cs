﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryApplication.Models
{
    public class Album
    {
        public Guid Id { get; set; }
        public string AlbumName { get; set; }
        public List<Picture> Pictures { get; set; }
    }
}
