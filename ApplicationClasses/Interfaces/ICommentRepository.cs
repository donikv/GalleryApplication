using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ApplicationClasses.Models;

namespace ApplicationClasses.Interfaces
{
    interface ICommentRepository : IRepository<Comment>
    {
        List<Comment> GetCommentsForPicture(Picture picture);
        List<Comment> GetCommentsForPicture(Guid pictureId);
    }

}
