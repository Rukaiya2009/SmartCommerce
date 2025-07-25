using System.ComponentModel.DataAnnotations;

namespace SmartCommerce.Models
{
    public class Ebook : Product
    {
        [Required]
        [MaxLength(255)]
        public string Author { get; set; } = string.Empty;

        [MaxLength(20)]
        public string ISBN { get; set; } = string.Empty;

        [MaxLength(50)]
        public string FileFormat { get; set; } = "PDF";

        [Range(1, int.MaxValue)]
        public int PageCount { get; set; }

        [Url]
        public string? CoverImageUrl { get; set; }

        public DateTime PublishedDate { get; set; }

        [MaxLength(100)]
        public string? Language { get; set; }

        [MaxLength(255)]
        public string? Publisher { get; set; }

        [MaxLength(255)]
        public string? DigitalRightsManagement { get; set; }

        [MaxLength(500)]
        public string? Tags { get; set; }

        [MaxLength(100)]
        public string? LicenseType { get; set; }

        [MaxLength(2000)]
        public string? Summary { get; set; }

        [MaxLength(1000)]
        public string? TagsDescription { get; set; }

        [MaxLength(1000)]
        public string? Keywords { get; set; }

        [MaxLength(2000)]
        public string? AdditionalResources { get; set; }
    }
} 