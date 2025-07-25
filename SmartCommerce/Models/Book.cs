using System.ComponentModel.DataAnnotations;

namespace SmartCommerce.Models
{
    public class Book : Product
    {
        [Required]
        [MaxLength(255)]
        public string BookName { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string AuthorName { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string ISBN { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int PageCount { get; set; }

        [MaxLength(100)]
        public string BindingType { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Dimensions { get; set; } = string.Empty;

        public DateTime PublishedDate { get; set; }

        [MaxLength(100)]
        public string Language { get; set; } = "English";

        [MaxLength(255)]
        public string Publisher { get; set; } = string.Empty;

        [Url]
        public string? CoverImageUrl { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; } = null!;
    }
}
