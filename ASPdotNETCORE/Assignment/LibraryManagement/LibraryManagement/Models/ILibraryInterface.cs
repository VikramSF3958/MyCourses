using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public interface ILibraryInterface
    {
        public IEnumerable<Bookcategories> GetBookCategories();

        public IEnumerable<Books> GetBooks();
        public Books GetBookById(int bookId);
    }
}
