using System;

namespace ApplicationClasses.Models
{
    public class Comment:Model
    {
        public Guid OwnerId { get; set; }
        public string CommentText { get; set; }

    }
}
