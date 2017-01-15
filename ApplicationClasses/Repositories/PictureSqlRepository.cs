using System;
using System.Collections.Generic;
using System.Linq;
using ApplicationClasses.Interfaces;
using ApplicationClasses.Models;

namespace ApplicationClasses.Repositories
{
    public class PictureSqlRepository : DefaultSqlRepository<Picture>,IPictureRepository
    {

        public PictureSqlRepository(GalleryDbContext context):base(context,context.Pictures)
        {
        }

        public List<Picture> GetAlbumPictures(Album album)
        {
            return album.Pictures;
        }
        public List<Picture> GetAlbumPictures(Guid albumId)
        {
            var album = _context.Albums.FirstOrDefault(x => x.Id.Equals(albumId));
            return GetAlbumPictures(album);
        }
    }
}
