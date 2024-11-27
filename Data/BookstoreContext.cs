using Microsoft.EntityFrameworkCore;
using Bookstore.Models;

namespace Bookstore.Data
{
    public class BookstoreContext : DbContext
    {
        internal readonly object Books;

        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options) 
        {
        }

        public DbSet<Genre> Genres { get; set; }
    }
}
