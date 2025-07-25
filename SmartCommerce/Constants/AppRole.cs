using SmartCommerce.Models.SmartCommerce.Models;
using System.ComponentModel.DataAnnotations;

namespace SmartCommerce.Models
{
    // Models/Role.cs
    public class AppRole
    {
        public int AppRoleId { get; set; }
        public required string RoleName { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
    }

}
