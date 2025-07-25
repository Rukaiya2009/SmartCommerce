using SmartCommerce.Models.SmartCommerce.Models;

namespace SmartCommerce.Models
{
    // ShoppingCart.cs
    public class ShoppingCart
    {
        public int Id { get; set; }
        public ApplicationUser? User { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public ICollection<CartItem> CartItems { get; set; }
        public CartDetail CartDetail { get; set; }
    }

}
