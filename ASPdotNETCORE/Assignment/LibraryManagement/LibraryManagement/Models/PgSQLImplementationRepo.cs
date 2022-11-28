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

        public Books Add(Books book)
        {
            if (book == null)
            {
                throw new NullReferenceException("Book is Data is Null");
            }
            book.Bookid = _context.Books.Max( e=> e.Bookid) + 1;
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
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
