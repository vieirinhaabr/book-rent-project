using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Booker.Models;

namespace Booker.ViewModels
{
    public class CustomerBooksViewModel
    {
        public Customer Customer { get; set; }
        public IQueryable<Book> Books { get; set; }
    }
}