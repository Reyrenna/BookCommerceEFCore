using System.ComponentModel.DataAnnotations;

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
        [StringLength(100)]
        public required string Genre { get; set; }

        [Required]
        public required bool IsStock { get; set; }

        public string? ImageUrl { get; set; }
    }
}
