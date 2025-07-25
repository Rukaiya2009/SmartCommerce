using System.ComponentModel.DataAnnotations;

namespace SmartCommerce.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        public string GenreName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Ebook> Ebooks { get; set; } = new List<Ebook>();
        public ICollection<Book> Books { get; set; } = new List<Book>();
    
    }

}
