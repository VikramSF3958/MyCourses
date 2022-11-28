using System;
using System.Collections.Generic;

namespace LibraryManagement.Models
{
    public partial class Bookcategories
    {
        public Bookcategories()
        {
            Indextable = new HashSet<Indextable>();
        }

        public int Cateogoryid { get; set; }
        public string Cateogoryname { get; set; }
        public DateTime Updatedon { get; set; }
        public bool Isdeleted { get; set; }

        public virtual ICollection<Indextable> Indextable { get; set; }
    }
}
