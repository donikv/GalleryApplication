using System.Collections.Generic;

namespace ApplicationClasses.Models
{
    public class Picture:Model
    {
        public string FilePath { get; set; }
        public Album RespectiveAlbum { get; set; }
        public User Owner { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
