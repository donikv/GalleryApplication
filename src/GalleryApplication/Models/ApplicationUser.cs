﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationClasses.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GalleryApplication.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        private User user;
    }
}
