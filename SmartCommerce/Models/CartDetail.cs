namespace SmartCommerce.Models
{
    // CartDetail.cs
    public class CartDetail
    {
        public int CartDetailId { get; set; }

        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        public decimal? TotalAmount { get; set; }
        public decimal? Discount { get; set; }
        public decimal? FinalAmount { get; set; }

    }

}