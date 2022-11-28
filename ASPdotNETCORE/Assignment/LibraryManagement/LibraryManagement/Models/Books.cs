using System;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public partial class Books
    {
        public Books()
        {
            Indextable = new HashSet<Indextable>();
        }

        public int Bookid { get; set; }
        public string Bookname { get; set; }
        public string Authorname { get; set; }
        public int? Publishedyear { get; set; }
        public decimal? Price { get; set; }
        public int Bookcategoryid { get; set; }
        public DateTime Updatedon { get; set; }
        public bool Isdeleted { get; set; }

        public virtual ICollection<Indextable> Indextable { get; set; }
    }
}
