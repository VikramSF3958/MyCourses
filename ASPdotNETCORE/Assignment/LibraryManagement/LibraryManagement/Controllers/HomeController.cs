using LibraryManagement.Models;
using LibraryManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILibraryInterface _libraryRepository;

        //private readonly ILogger<HomeController> _logger;

        public HomeController(ILibraryInterface libraryRepo)
        {
            _libraryRepository = libraryRepo;
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        [Route("")]
        public IActionResult Index()
        {
            //Returning all non-deleted Books
            IEnumerable<NewBookViewModel> model = _libraryRepository.GetViewBooks().Where(e => e.Isdeleted == false).OrderBy(e => e.Bookcategoryid).ThenBy(e => e.Bookname);
            return View(model);
        }


        public IActionResult GetBook(int id)
        {
            Books book = _libraryRepository.GetBookById(id);

            //If No Book is Returned
            if (book == null)
            {
                Response.StatusCode = 404;
                ViewBag.Reason = "Data Not Found";
                return View("NotFoundPage", id);
            }

            var categoryName = _libraryRepository.GetBookCategories().FirstOrDefault(e => e.Cateogoryid == book.Bookcategoryid);
            BookViewModels model = new BookViewModels()
            {
                books = book,
                CategoryName = categoryName.Cateogoryname
            };
            ViewBag.Header = "Book Details";
            return View("BookDetails", model);
        }


        [HttpGet]
        public IActionResult AddBook()
        {
            List<Bookcategories> item = new List<Bookcategories>();

            //Adding Dropdown List
            item = (from category in _libraryRepository.GetBookCategories() select category).ToList();
            item.Insert(0, new Bookcategories { Cateogoryid = 0, Cateogoryname = "Select" });
            ViewBag.ItemList = item;

            return View();
        }


        [HttpPost]
        public IActionResult AddBook(Books book)
        {
            if (book == null)
            {
                Response.StatusCode = 404;
                ViewBag.Reason = "Data Empty";
                return View("NotFoundPage");
            }

            var result = _libraryRepository.GetBooks().Where(e => e.Bookname == book.Bookname);
            foreach (var val in result)
            {
                if (val.Bookname == book.Bookname)
                {
                    Response.StatusCode = 404;
                    ViewBag.Reason = "Data Already Exists";
                    return View("NotFoundPage");
                }
            }

            Books newBook = _libraryRepository.Add(book);
            return RedirectToAction("GetBook", new { id = newBook.Bookid });

        }


        [HttpGet]
        public IActionResult EditBook(int id)
        {
            List<Bookcategories> item = new List<Bookcategories>();

            //Adding Dropdown list
            item = (from category in _libraryRepository.GetBookCategories() select category).ToList();
            item.Insert(0, new Bookcategories { Cateogoryid = 0, Cateogoryname = "Select" });
            ViewBag.ItemList = item;

            Books books = _libraryRepository.GetBookById(id);
            return View(books);
        }


        [HttpPost]
        public IActionResult EditBook(Books book)
        {
            Books updatedBook = _libraryRepository.EditBooks(book);
            return RedirectToAction("GetBook", new { id = updatedBook.Bookid });
        }

        
        public IActionResult DeleteBook(int id)
        {
            Books books = _libraryRepository.DeleteBook(id);

            var categoryName = _libraryRepository.GetBookCategories().FirstOrDefault(e => e.Cateogoryid == books.Bookcategoryid);
            BookViewModels model = new BookViewModels()
            {
                books = books,
                CategoryName = categoryName.Cateogoryname
            };

            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
