using Bookstore.Data;

namespace Bookstore.Services
{
    public class SeedingService
    {
        private readonly BookstoreContext _context;
        public SeedingService(BookstoreContext context)
        {
            _context = context;
        }

        //public async Task Seed()
        //{
        // if (_context.Genres.Any() ||
        //    _context.Books.Any() 
        //  )
        // {
        //    return; // Db já foi semeado.
        //   }
        //}
    }

}
