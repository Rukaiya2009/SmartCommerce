using SmartCommerce.Models.SmartCommerce.Models;

namespace SmartCommerce.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public string UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public int Rating { get; set; } // 1 to 5
        public string? Comment { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

}
