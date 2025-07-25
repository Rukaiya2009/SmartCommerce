namespace SmartCommerce.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.ComponentModel.DataAnnotations;

    namespace SmartCommerce.Models
    {
        public class ApplicationUser : IdentityUser
        {
            public required string FullName { get; set; }
            public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
            public string? ProfilePicturePath { get; set; }

            // Custom Role relation
            public int AppRoleId { get; set; }
            public AppRole AppRole { get; set; }


        }
    }


}