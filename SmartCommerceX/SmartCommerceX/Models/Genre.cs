using SmartCommerce.Models;
namespace SmartCommerceX.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
} 