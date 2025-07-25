using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartCommerceX.Data
{
    public enum AppRole
    {
        Admin = 1,
        Seller = 2,
        Customer = 3,
        DeliveryAgent = 4
    }

    [Table("ApplicationUsers")]
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(100)]
        public string FullName { get; set; }

        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;

        public string? ProfilePicturePath { get; set; }

        public AppRole AppRole { get; set; } = AppRole.Customer; // default role
    }
}
