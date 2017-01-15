using System;
using System.Collections.Generic;
using ApplicationClasses.Models;

namespace ApplicationClasses.Interfaces
{
    interface IAlbumRepository : IRepository<Album>
    {
        List<Album> GetUserAlbums(Guid userId);
        List<Album> GetUserAlbums(User user);
    }
}
