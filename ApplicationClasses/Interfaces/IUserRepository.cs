using System;
using System.Collections.Generic;
using ApplicationClasses.Models;

namespace ApplicationClasses.Interfaces
{
    public interface IUserRepository
    {
        User Get(Guid id);

        //Ovo vraca usere na koje je taj user pretplacen
        List<User> GetSubscriptions(Guid userId);
        List<User> GetSubscriptions(User user);

        //Ovo vraca usere koji su na njega pretplaceni
        List<User> GetSubscribed(Guid userId);
        List<User> GetSubscribed(User user);
    }

}
