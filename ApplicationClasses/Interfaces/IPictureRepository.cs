using System.Collections.Generic;
using ApplicationClasses.Models;
using System;

namespace ApplicationClasses.Interfaces
{
    public interface IPictureRepository : IRepository<Picture>
    {
        List<Picture> GetAlbumPictures(Album album);
        List<Picture> GetAlbumPictures(Guid albumId);
    }
}
