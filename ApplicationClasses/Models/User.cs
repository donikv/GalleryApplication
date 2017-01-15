using System;
using System.Collections.Generic;

namespace ApplicationClasses.Models
{ 
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class User:Model
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; }

        //Ovo je lista onih na koje je pretplacen
        public List<User> SubscribedTo { get; set; }

        //Ovo je lista njegovih pretplatnika
        public List<User> OwnSubscribers { get; set; }

        public User(Guid id, string name)
        {
            Name = name;
            Id = id;
            Albums=new List<Album>();
            SubscribedTo=new List<User>();
            OwnSubscribers=new List<User>();
            Console.WriteLine("Stovrio novog usera: "+ Id.ToString());
        }

        public User()
        {
        }

    }
}
