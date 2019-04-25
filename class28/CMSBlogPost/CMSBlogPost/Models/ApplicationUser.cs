using Microsoft.AspNetCore.Identity;
using System;

namespace CMSBlogPost.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
    }
}
