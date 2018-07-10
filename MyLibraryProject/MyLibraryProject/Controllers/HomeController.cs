using MyLibraryProject.Models;
using MyLibraryProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyLibraryProject.Controllers
{
    public class HomeController : Controller
    {
        BooksContext booksContext = new BooksContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllTheBooks()
        {
            List<Book> AllOfTheBooks = new List<Book>();

            foreach (Book book in booksContext.Books)
            {
                AllOfTheBooks.Add(book);
            }

            return View(AllOfTheBooks);
        }

        public ActionResult BookDetail(int? BookId)
        {
            if (BookId == null)
            {
              return HttpNotFound();
            }

            // Selects the book based on Book.Id
            
            var book = booksContext.GetBook((int)BookId);

            return View(book);

        }
    }
}