using BookCommerceEFCore.Models;
using Microsoft.EntityFrameworkCore;
namespace BookCommerceEFCore.Data
{
    public class BookCommerceEFCoreDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BookCommerceEFCoreDbContext(DbContextOptions<BookCommerceEFCoreDbContext> options) : base(options) { 
        
        }
        
    }
}
