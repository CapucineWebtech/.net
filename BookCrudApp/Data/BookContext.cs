using Microsoft.EntityFrameworkCore;
using BookCrudApp.Models;

namespace BookCrudApp.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
