using System;
using System.Collections.Generic;
using ApplicationClasses.Models;

namespace ApplicationClasses.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {

        //Ovo vraca usere na koje je taj user pretplacen
        List<Guid> GetSubscriptions(Guid userId);
        List<Guid> GetSubscriptions(User user);
        void AddSubscriber(Guid id, User user);
        //Ovo vraca usere koji su na njega pretplaceni
        List<Guid> GetSubscribed(Guid userId);
        List<Guid> GetSubscribed(User user);
    }

}
