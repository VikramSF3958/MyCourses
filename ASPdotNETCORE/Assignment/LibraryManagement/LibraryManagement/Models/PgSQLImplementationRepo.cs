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

            book.Bookid = _context.Books.Max(e => e.Bookid) + 1;
            book.Updatedon = DateTime.Now;
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
            //var updatedBook = _context.Books.Attach(book);
            //updatedBook.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            Books rbook = _context.Books.Find(book.Bookid);
            rbook.Bookname = book.Bookname;
            rbook.Authorname = book.Authorname;
            rbook.Bookcategoryid = book.Bookcategoryid;
            rbook.Publishedyear = book.Publishedyear;
            rbook.Price = book.Price;
            rbook.Updatedon = DateTime.Now;

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

        public bool IsContains(Books books)
        {
            //Result book
            Books rbook = _context.Books.Find(books.Bookid);

            if (rbook.Bookname == books.Bookname &&
                rbook.Authorname == books.Authorname &&
                rbook.Bookcategoryid == books.Bookcategoryid &&
                rbook.Publishedyear == books.Publishedyear &&
                rbook.Price == books.Price
                )
            {
                return true;
            }

            return false;
        }

        public bool IsDuplicate(string bookName)
        {
            var result = _context.Books.Where(e => e.Bookname == bookName);
            foreach (var val in result)
            {
                if (val.Bookname == bookName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
