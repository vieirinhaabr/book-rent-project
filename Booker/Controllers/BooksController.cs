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
    public class BooksController : Controller
    {
        private ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {

            var books = _context.Books.ToList();

            return View(books);
        }

        public ActionResult New()
        {
            ViewBag.Years = new SelectList(Enumerable.Range(DateTime.Today.Year - 100, 101).Select(x =>

           new SelectListItem()
           {
               Text = x.ToString(),
               Value = x.ToString()
           }), "Value", "Text");

            var viewModel = new BookFormViewModel
            {
                Book = new Book()
            };

            return View("BookForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Book book)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new BookFormViewModel
                {
                    Book = new Book()
                };

                return View("BookForm", viewModel);
            }

            if (book.Id == 0)
            {
                _context.Books.Add(book);
            }
            else
            {
                var bookInDb = _context.Books.Single(c => c.Id == book.Id);

                bookInDb.Title = book.Title;
                bookInDb.Author = book.Author;
                bookInDb.YearOfPublication = book.YearOfPublication;
                bookInDb.NumberInStock = book.NumberInStock;
                bookInDb.NumberRented = book.NumberRented;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Books");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {

            if (id > 0)
            {
                var bookInDb = _context.Books.SingleOrDefault(c => c.Id == id);

                _context.Books.Remove(bookInDb);
                _context.SaveChanges();
            }


            return RedirectToAction("Index", "Books");

        }


        public ActionResult Details(int id)
        {


            if (Session["Customer"] != null) {
                int customerId = Convert.ToInt32(Session["Customer"]);
                var cBook = _context.CustomerBooks.SingleOrDefault(c => c.BookId == id && c.CustomerId == customerId);

                bool rentedBySession;

                if (cBook != null)
                    rentedBySession = true;
                else
                    rentedBySession = false;

                var viewModel = new BookCustomerViewModel
                {
                    Book = _context.Books.SingleOrDefault(c => c.Id == id),
                    RentedBySession = rentedBySession
                };

                if (viewModel.Book == null)
                    return HttpNotFound();

                return View(viewModel);
            }
            else
            {
                var viewModel = new BookCustomerViewModel
                {
                    Book = _context.Books.SingleOrDefault(c => c.Id == id),
                    RentedBySession = false
                };
                if (viewModel.Book == null)
                    return HttpNotFound();

                return View(viewModel);
            }
            
        }


        public ActionResult Edit(int id)
        {

            ViewBag.Years = new SelectList(Enumerable.Range(DateTime.Today.Year - 100, 101).Select(x =>

           new SelectListItem()
           {
               Text = x.ToString(),
               Value = x.ToString()
           }), "Value", "Text");


            var book = _context.Books.SingleOrDefault(c => c.Id == id);

            if (book == null)
                return HttpNotFound();

            var viewModel = new BookFormViewModel
            {
                Book = book
            };

            return View("BookForm", viewModel);
        }

        public ActionResult Return()
        {
            Session.Abandon();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult AddCustomerBook(int id)
        {

            var book = _context.Books.SingleOrDefault(c => c.Id == id);

            if (id > 0 && book.NumberInStock > 0)
            {
                var model = new CustomerBooks()
                {
                    BookId = id,
                    CustomerId = Convert.ToInt32(Session["Customer"])
                };

                book.NumberInStock--;
                book.NumberRented++;

                _context.CustomerBooks.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }
                
        }
        public ActionResult ReturnBook(int id)
        {
            if (id > 0 && Session["Customer"] != null)
            {
                var book = _context.Books.SingleOrDefault(c => c.Id == id);

                int customerId = Convert.ToInt32(Session["Customer"]);
                var cBook = _context.CustomerBooks.SingleOrDefault(c => c.BookId == id && c.CustomerId == customerId);


                book.NumberInStock++;
                book.NumberRented--;

                _context.CustomerBooks.Remove(cBook);
                _context.SaveChanges();


                return RedirectToAction("Index", "Books");
            }

            return HttpNotFound();
        }
    }
}