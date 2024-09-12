using Microsoft.EntityFrameworkCore;

namespace BookStoreWebapi.DBOperations
{
    public class BookStorageDBContext : DbContext
    {
        public BookStorageDBContext(DbContextOptions<BookStorageDBContext> options) : base(options)
        { }

        public DbSet<Book> Books { get; set; }
    }
}