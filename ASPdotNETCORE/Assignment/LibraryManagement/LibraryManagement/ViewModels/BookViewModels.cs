using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.ViewModels
{
    public class BookViewModels
    {
        public Books books { get; set; }

        public string CategoryName { get; set; }
    }
}
