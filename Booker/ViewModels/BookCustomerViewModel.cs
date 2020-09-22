using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Booker.Models;

namespace Booker.ViewModels
{
    public class BookCustomerViewModel
    {
        public Book Book { get; set; }
        public bool RentedBySession { get; set; }
    }
}