using System;
using System.Collections.Generic;
using System.Linq;
using ApplicationClasses.Interfaces;
using ApplicationClasses.Models;

namespace ApplicationClasses.Repositories
{
    class AlbumSqlRepository : DefaultSqlRepository<Album>, IAlbumRepository
    {
        public AlbumSqlRepository(GalleryDbContext context) : base(context, context.Albums)
        {
        }

        public List<Album> GetUserAlbums(Guid userId)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == userId);
            return GetUserAlbums(user);
        }

        public List<Album> GetUserAlbums(User user)
        {
            return user.Albums;
        }
    }
}

