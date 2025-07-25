namespace SmartCommerce.Models
{
    using global::SmartCommerce.Models.SmartCommerce.Models;
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        [Required]
        public string ShippingAddress { get; set; }

        public decimal TotalAmount { get; set; }

        public string Status { get; set; } = "Pending";  // Pending, Paid, Shipped, Delivered

        public ICollection<OrderItem>? OrderItems { get; set; }
        public Payment Payment { get; set; }

    }

}
