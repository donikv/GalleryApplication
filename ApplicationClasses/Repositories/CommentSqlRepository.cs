using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationClasses.Interfaces;
using ApplicationClasses.Models;

namespace ApplicationClasses.Repositories
{
    class CommentSqlRepository:DefaultSqlRepository<Comment>,ICommentRepository
    {
        public CommentSqlRepository(GalleryDbContext context) : base(context, context.Comments)
        {
        }


        public List<Comment> GetCommentsForPicture(Picture picture)
        {
            if(picture==null)
                throw new ArgumentNullException();
            return picture.Comments;
        }

        public List<Comment> GetCommentsForPicture(Guid pictureId)
        {
            var picture = _context.Pictures.FirstOrDefault(x => x.Id.Equals(pictureId));
            return GetCommentsForPicture(picture);
        }
    }
}
