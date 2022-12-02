using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.ViewModels
{
    public class NewBookViewModel
    {
        public int Bookid { get; set; }
        public string Bookname { get; set; }
        public string Authorname { get; set; }
        public int Bookcategoryid { get; set; }
        public int? Publishedyear { get; set; }
        public decimal? Price { get; set; }
        public string Cateogoryname { get; set; }
        public DateTime Updatedon { get; set; }
        public bool Isdeleted { get; set; }
    }
}
