using LibraryManagement.ViewModels;
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

        public Books DeleteBook(int id)
        {
            Books books = _context.Books.Find(id);

            books.Isdeleted = true;

            var toDelete = _context.Books.Attach(books);
            toDelete.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            //if(books!=null)
            //{
            //    _context.Books.Remove(books);
            //    _context.SaveChanges();
            //}

            return books;
        }

        public Books EditBooks(Books book)
        {
            var updatedBook = _context.Books.Attach(book);
            updatedBook.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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

        public IEnumerable<NewBookViewModel> GetViewBooks()
        {
             var data = from b in _context.Books
                        from b2 in _context.Bookcategories
                        where b.Bookcategoryid == b2.Cateogoryid
                        select new NewBookViewModel
                        {
                            Bookid = b.Bookid,
                            Bookname = b.Bookname,
                            Authorname = b.Authorname,
                            Bookcategoryid = b.Bookcategoryid,
                            Publishedyear = b.Publishedyear,
                            Price = b.Price,
                            Updatedon = b.Updatedon,
                            Isdeleted = b.Isdeleted,
                            Cateogoryname = b2.Cateogoryname
                        };

            return data;
        }
    }
}
