﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace src.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [StringLength(250)]
        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; } = "#";

        public bool IsSuperAdmin { get; set; } = false;
    }
}
