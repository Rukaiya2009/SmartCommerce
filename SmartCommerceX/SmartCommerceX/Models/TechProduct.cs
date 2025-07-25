using SmartCommerce.Models;

namespace SmartCommerceX.Models
{
    public class TechProduct : Product
    {
        public string? Processor { get; set; }
        public string? RAM { get; set; }
        public string? Storage { get; set; }
        public string? Brand { get; set; }
    }
} 