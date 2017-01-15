using System.Collections.Generic;

namespace ApplicationClasses.Models
{
    public class Album :Model
    {
        public User Owner { get; set; }
        public string AlbumName { get; set; }
        public List<Picture> Pictures { get; set; }
    }
}
