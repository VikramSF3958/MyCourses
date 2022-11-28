using LibraryManagement.Models;
using LibraryManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
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
            IEnumerable<Books> book = _libraryRepository.GetBooks().Where( e => e.Isdeleted == false).OrderBy(e => e.Bookcategoryid).ThenBy( e=> e.Bookname);
            return View(book);
        }

        public IActionResult GetBook(int id)

        {
            Books book = _libraryRepository.GetBookById(id);

            //If No Book is Returned
            if (book == null)
            {
                Response.StatusCode = 404;
                return View("NotFoundPage", id);
            }

            var categoryName = _libraryRepository.GetBookCategories().FirstOrDefault(e => e.Cateogoryid == book.Bookcategoryid);
            BookViewModels model = new BookViewModels()
            {
                books = book,
                CategoryName = categoryName.Cateogoryname
            };

            return View("BookDetails", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
