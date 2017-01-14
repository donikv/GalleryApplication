using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationClasses
{
    public class Comment
    {
        public Guid Id { get; set; }
        public User Owner { get; set; }
        public string CommentText { get; set; }

    }
}
