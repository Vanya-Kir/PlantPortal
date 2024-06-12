﻿using Microsoft.AspNetCore.Identity;

namespace PlantPortal.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
