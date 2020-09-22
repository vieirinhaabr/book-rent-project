using System.Data.Entity;

namespace Booker.Models
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<CustomerBooks> CustomerBooks { get; set; }
    }
}