using System;
using System.Collections.Generic;
using ApplicationClasses.Models;

namespace ApplicationClasses.Interfaces
{
    public interface IAlbumRepository : IRepository<Album>
    {
        List<Album> GetUserAlbums(Guid userId);
        List<Album> GetUserAlbums(User user);
    }
}
