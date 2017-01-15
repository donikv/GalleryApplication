using System.Collections.Generic;
using ApplicationClasses.Models;
using System;

namespace ApplicationClasses.Interfaces
{
    interface IPictureRepository : IRepository<Picture>
    {
        List<Picture> GetAlbumPictures(Album album);
        List<Picture> GetAlbumPictures(Guid albumId);
    }
}
