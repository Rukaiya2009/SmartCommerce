using SmartCommerce.Models;

namespace SmartCommerceX.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public ICollection<CartItem> CartItems { get; set; }
        public CartDetail CartDetail { get; set; }
    }

    public class CartItem
    {
        public int Id { get; set; }

        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }

    public class CartDetail
    {
        public int Id { get; set; }

        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        public decimal? TotalAmount { get; set; }
        public decimal? Discount { get; set; }
        public decimal? FinalAmount { get; set; }
    }
} 