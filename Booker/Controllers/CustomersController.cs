using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Booker.Models;
using Booker.ViewModels;
using System.Data.Entity;

namespace Booker.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var customers = _context.Customers.ToList();

            Session.Remove("Customer");

            return View(customers);
        }

        public ActionResult New()
        {
            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer()
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = new Customer()
                };

                return View("CustomerForm", viewModel);
            }

            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
            }
            _context.SaveChanges();

            return RedirectToAction("Details/" + customer.Id, "Customers");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            
            if (id > 0)
            {
                var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

                var books = (from cb in _context.CustomerBooks
                             join b in _context.Books on cb.BookId equals b.Id
                             where cb.CustomerId == customerInDb.Id
                             select cb);

                foreach(var cbook in books)
                {
                    var book = _context.Books.SingleOrDefault(c => c.Id == cbook.BookId);

                    book.NumberInStock++;
                    book.NumberRented--;
                }

                _context.CustomerBooks.RemoveRange(books);
                _context.Customers.Remove(customerInDb);
                _context.SaveChanges();
            }
            
            
            return RedirectToAction("Index", "Customers");
            
        }


        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            var books = (from b in _context.Books
                         join cb in _context.CustomerBooks on b.Id equals cb.BookId
                         where cb.CustomerId == customer.Id
                         select b);

            Session.Add("Customer", id);

            var viewModel = new CustomerBooksViewModel
            {
                Customer = customer,
                Books = books
            };

            if (customer == null)
                return HttpNotFound();
            
            return View(viewModel);
        }


        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer
            };

            return View("CustomerForm", viewModel);
        }


        public ActionResult Browse(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            Session.Add("Customer", id);

            return RedirectToAction("Index", "Books");
        }

        

    }
}
