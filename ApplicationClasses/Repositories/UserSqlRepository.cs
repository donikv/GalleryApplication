using System;
using System.Collections.Generic;
using System.Linq;
using ApplicationClasses.Interfaces;
using ApplicationClasses.Models;

namespace ApplicationClasses.Repositories
{
    public class UserSqlRepository : DefaultSqlRepository<User>, IUserRepository
    {
        public UserSqlRepository(GalleryDbContext context) : base(context, context.Users)
        {
        }

        public List<User> GetSubscriptions(Guid userId)
        {
            var user = _subContext.FirstOrDefault(x => x.Id.Equals(userId));
            return GetSubscriptions(user);
        }

        public List<User> GetSubscriptions(User user)
        {
            return user.SubscribedTo;
        }

        public List<User> GetSubscribed(Guid userId)
        {
            var user = _subContext.FirstOrDefault(x => x.Id.Equals(userId));
            return GetSubscribed(user);
        }

        public List<User> GetSubscribed(User user)
        {
            return user.OwnSubscribers;
        }

    }
}
