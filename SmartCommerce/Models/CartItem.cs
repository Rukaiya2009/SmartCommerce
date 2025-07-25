﻿using SmartCommerce.Models.SmartCommerce.Models;

namespace SmartCommerce.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int Quantity { get; set; }
    }

}
