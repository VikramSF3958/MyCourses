using System;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public partial class Indextable
    {
        public int Indexid { get; set; }
        public int? Indexbookcategoryid { get; set; }
        public int? Indexbookid { get; set; }

        public virtual Books Indexbook { get; set; }
        public virtual Bookcategories Indexbookcategory { get; set; }
    }
}
