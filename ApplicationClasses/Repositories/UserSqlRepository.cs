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

        public List<Guid> GetSubscriptions(Guid userId)
        {
            var user = _subContext.FirstOrDefault(x => x.Id.Equals(userId));
            return GetSubscriptions(user);
        }

        public List<Guid> GetSubscriptions(User user)
        {
            return user.SubscribedTo;
        }

        public void AddSubscriber(Guid id, User user)
        {
            GetSubscriptions(user).Add(id);
            Update(user);
        }

        public List<Guid> GetSubscribed(Guid userId)
        {
            var user = _subContext.FirstOrDefault(x => x.Id.Equals(userId));
            return GetSubscribed(user);
        }

        public List<Guid> GetSubscribed(User user)
        {
            return user.OwnSubscribers;
        }

    }
}
