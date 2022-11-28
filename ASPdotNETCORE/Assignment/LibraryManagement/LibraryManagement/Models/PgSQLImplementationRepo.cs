using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class PgSQLImplementationRepo : ILibraryInterface
    {
        private readonly libraryContext _context;

        public PgSQLImplementationRepo(libraryContext context)
        {
            this._context = context;
        }

        public Books GetBookById(int bookId)
        {
            Books book = _context.Books.Find(bookId);
            return book;
        }

        public IEnumerable<Bookcategories> GetBookCategories()
        {
            return _context.Bookcategories;
        }

        public IEnumerable<Books> GetBooks()
        {
            return _context.Books;
        }
    }
}
