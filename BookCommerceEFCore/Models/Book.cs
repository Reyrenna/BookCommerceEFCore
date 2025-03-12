using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCommerceEFCore.Models
{
    public class Book
    {
        [Key]
        public required Guid Id { get; set; }

        [Required]
        [StringLength(300)]
        public required string Title { get; set; }

        [Required]
        [StringLength(50)]
        public required string Author { get; set; }

        [Required]
        public required bool IsStock { get; set; }

        public string? ImageUrl { get; set; }

        public ICollection<Genre> Genres { get; set; }

    }
}
