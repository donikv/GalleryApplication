using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationClasses
{
    class UserSqlRepository : IUserRepository
    {
        private readonly GalleryDbContext _context;

        public UserSqlRepository(GalleryDbContext context)
        {
            _context = context;
        }

        public User Get(Guid Id)
        {
            if (Id == null)
            {
                throw new ArgumentNullException();
            }
            return _context.Users.FirstOrDefault(s => s.Id.Equals(Id));
        }

        public void Add(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException();
            }

        }

        public bool Remove(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
