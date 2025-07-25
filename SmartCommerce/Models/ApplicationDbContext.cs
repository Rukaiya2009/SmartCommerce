using SmartCommerce.Constants;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartCommerce.Models;
using SmartCommerce.Models.SmartCommerce.Models;
using SmartCommerce.Data;

namespace SmartCommerce.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Identity-related
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }  // Renamed!

        // Product-related
        public DbSet<Product> Products { get; set; }
        public DbSet<Book> Books { get; set; } // Add this if Book exists!
        public DbSet<Ebook> Ebooks { get; set; }
        public DbSet<TechProduct> TechProducts { get; set; }
        public DbSet<CosmeticProduct> CosmeticProducts { get; set; }

        // Order-related
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        // Shopping Cart
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        // Others
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
