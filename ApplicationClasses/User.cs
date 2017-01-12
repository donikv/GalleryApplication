using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationClasses
{ 
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
        public List<User> Friends { get; set; }

          public User(Guid Id, string Name)
        {
            this.Name = Name;
            this.Id = Id;
            Albums=new List<Album>();
            Friends=new List<User>();
        }

    }
}
