using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApplication.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string Name { get; set; }


    }
}
