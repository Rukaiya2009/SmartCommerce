namespace SmartCommerce.Models
{
    // Stock.cs
    public class Stock
    {
        public int StockId { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int QuantityAvailable { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }

}
