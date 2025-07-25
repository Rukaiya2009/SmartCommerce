namespace SmartCommerceX.Models
{
    public class TransactionHistory
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string Action { get; set; } // e.g., "PaymentReceived", "OrderShipped", "Refunded", etc.
        public string PerformedBy { get; set; } // Could be Admin/User
    }
} 