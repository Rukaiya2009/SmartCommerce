using System;
using System.ComponentModel.DataAnnotations;

namespace SmartCommerceX.Models
{
    public class Payment
    {
        public int Id { get; set; }

        // Foreign Key to Order
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        [Required]
        public string PaymentMethod { get; set; } = string.Empty; // e.g. Card, bKash, Stripe

        [Required]
        public string PaymentStatus { get; set; } = "Pending";  // e.g. Pending, Completed, Failed

        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        public string? TransactionId { get; set; }

        [Range(0, double.MaxValue)]
        public decimal AmountPaid { get; set; }
    }
}
