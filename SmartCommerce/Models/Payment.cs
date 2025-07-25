using System.ComponentModel.DataAnnotations;

namespace SmartCommerce.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order? Order { get; set; }

        [Required]
        [MaxLength(50)]
        public string PaymentMethod { get; set; } = "Cash"; // Cash, Card, Bkash, Stripe

        public bool IsPaid { get; set; }

        public DateTime PaidAt { get; set; } = DateTime.UtcNow;

        [MaxLength(255)]
        public string? TransactionId { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal Amount { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = "Pending";
    }
}
