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
        public List<Guid> SubscribedTo { get; set; }

        //Ovo je lista njegovih pretplatnika
        public List<Guid> OwnSubscribers { get; set; }

        public User(Guid id, string name, List<Album> albums, List<Guid> subscribedTo, List<Guid> ownSubscribers)
        {
            Name = name;
            Id = id;
            Albums= albums;
            SubscribedTo= subscribedTo;
            OwnSubscribers= ownSubscribers;
            Console.WriteLine("Stovrio novog usera: "+ Id.ToString());
        }
        public User(Guid id, string name, List<Album> albums)
        {
            Name = name;
            Id = id;
            Albums = albums;
            SubscribedTo = new List<Guid>();
            OwnSubscribers = new List<Guid>();
            Console.WriteLine("Stovrio novog usera: " + Id.ToString());
        }
        public User(Guid id, string name, List<Guid> subscribedTo, List<Guid> ownSubscribers)
        {
            Name = name;
            Id = id;
            Albums = new List<Album>();
            SubscribedTo = subscribedTo;
            OwnSubscribers = ownSubscribers;
            Console.WriteLine("Stovrio novog usera: " + Id.ToString());
        }

        public User(Guid id, string name)
        {
            Name = name;
            Id = id;
            Albums = new List<Album>();
            SubscribedTo = new List<Guid>();
            OwnSubscribers = new List<Guid>();
            Console.WriteLine("Stovrio novog usera: " + Id.ToString());
        }
        public User()
        {
        }

    }
}
