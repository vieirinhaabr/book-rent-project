using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booker.Models
{
    public class CustomerBooks
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int BookId { get; set; }
    }
}