using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GalleryApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GalleryApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Picture> Pictures { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().Property(s => s.UserName).IsRequired();
            builder.Entity<ApplicationUser>().HasMany(s => s.Albums);
            builder.Entity<ApplicationUser>().HasMany(s => s.Friends);
            builder.Entity<Album>().HasMany(s => s.Pictures);
            builder.Entity<Album>().HasKey(s => s.Id);
            builder.Entity<Album>().Property(s => s.AlbumName).IsRequired();
            builder.Entity<Picture>().HasKey(s => s.Id);
            builder.Entity<Picture>().HasMany(s => s.Comments);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
