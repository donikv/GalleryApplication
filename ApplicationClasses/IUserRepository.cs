using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationClasses
{
    interface IUserRepository
    {
        User Get(Guid Id);
        void Add(User user);
        bool Remove(Guid Id);
        void Update(Guid Id);
/*
        List<User> GetAll();
        List<User> GetFiltered();*/
    }

}
