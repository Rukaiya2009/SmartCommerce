using SmartCommerceX.Data;
using SmartCommerceX.Models;
using System.ComponentModel.DataAnnotations;

namespace SmartCommerce.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(2000)]
        public string? Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        public bool IsDigital { get; set; } = false;

        [Url]
        public string? ImageUrl { get; set; }         // For physical products

        [Url]
        public string? DigitalFileUrl { get; set; }   // For downloadable products

        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; } = 0;

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public string? SellerId { get; set; }
        public ApplicationUser? Seller { get; set; }
    }
}
