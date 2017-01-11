using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GalleryApplication.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public Guid _Id { get; set; }
        public List<Album> _Albums { get; set; }
        public List<ApplicationUser> _Friends { get; set; }
    }
}
