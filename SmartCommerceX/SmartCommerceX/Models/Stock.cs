using SmartCommerce.Models;

namespace SmartCommerceX.Models
{
    public class Stock
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int QuantityAvailable { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
} 