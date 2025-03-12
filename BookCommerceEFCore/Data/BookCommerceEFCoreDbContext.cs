using BookCommerceEFCore.Models;
using Microsoft.EntityFrameworkCore;
namespace BookCommerceEFCore.Data
{
    public class BookCommerceEFCoreDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasMany(b => b.Genres).WithMany(g => g.Books);
        }


        public BookCommerceEFCoreDbContext(DbContextOptions<BookCommerceEFCoreDbContext> options) : base(options) { 
        
        }
        
    }
}
