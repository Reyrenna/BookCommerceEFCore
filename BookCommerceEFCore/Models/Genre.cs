using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCommerceEFCore.Models
{
    public class Genre
    {
        [Key]
        public required Guid IdGenre { get; set; }

        [Required]
        [StringLength(80)]
        public required string GenreName { get; set; }


        public ICollection<Book> Books { get; set; }

    }
}
