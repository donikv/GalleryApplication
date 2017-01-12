﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GalleryApplication.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public List<Album> Albums { get; set; }
        public List<ApplicationUser> Friends { get; set; }

/*        public ApplicationUser(Guid Id, String Name)
        {
            this.Name = Name;
            this.Id = Id;
            Albums=new List<Album>();
            Friends=new List<ApplicationUser>();
        }*/

    }
}
