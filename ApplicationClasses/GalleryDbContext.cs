using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationClasses.Models;


namespace ApplicationClasses
{
    public class GalleryDbContext : DbContext
    {
        public IDbSet<User> Users { get; set; }
        public IDbSet<Album> Albums { get; set; }
        public IDbSet<Picture> Pictures { get; set; }
        public IDbSet<Comment> Comments { get; set; }

        public GalleryDbContext(string connectionString) : base(connectionString)
        {

        }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().HasKey(s => s.Id);
            builder.Entity<User>().Property(s => s.Name).IsRequired();
            builder.Entity<User>().HasMany(s => s.Albums);
            builder.Entity<User>().HasMany(s => s.SubscribedTo);
            builder.Entity<User>().HasMany(s => s.OwnSubscribers);
            builder.Entity<Album>().HasMany(s => s.Pictures);
            builder.Entity<Album>().HasKey(s => s.Id);
            builder.Entity<Album>().Property(s => s.AlbumName).IsRequired();
            builder.Entity<Album>().HasRequired(s => s.Owner).WithMany(s => s.Albums);
            builder.Entity<Picture>().HasKey(s => s.Id);
            builder.Entity<Picture>().HasRequired(s => s.Owner);
            builder.Entity<Picture>().HasMany(s => s.Comments);
            builder.Entity<Comment>().HasKey(s => s.Id);
            builder.Entity<Comment>().Property(s => s.OwnerId);
            builder.Entity<Comment>().Property(s => s.CommentText);

        }
    }
}

