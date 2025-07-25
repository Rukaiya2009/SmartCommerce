using SmartCommerce.Models;

namespace SmartCommerceX.Models
{
    public class CosmeticProduct : Product
    {
        public string? SkinType { get; set; }
        public string? Ingredients { get; set; }
        public string? Brand { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
} 