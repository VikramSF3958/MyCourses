using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public partial class Books
    {
        public Books()
        {
            Indextable = new HashSet<Indextable>();
        }

        public int Bookid { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public string Bookname { get; set; }
        [RegularExpression(@"^[a-zA-Z]+(\s+[a-zA-Z]+)*$", ErrorMessage = "Use letters only please")]
        public string Authorname { get; set; }
        [Range(1, 2022, ErrorMessage = "Enter a valid Year")]
        public int? Publishedyear { get; set; }
        public decimal? Price { get; set; }
        public int Bookcategoryid { get; set; }
        public DateTime Updatedon { get; set; }
        public bool Isdeleted { get; set; }

        public virtual ICollection<Indextable> Indextable { get; set; }
    }
}
