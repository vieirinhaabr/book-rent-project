using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Booker.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        public string Author { get; set; }

        [Required]
        [Range(1900, 2019)]
        [Display(Name = "Year Published")]
        public int YearOfPublication { get; set; }

        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }

        public int NumberRented { get; set; }
    }
}