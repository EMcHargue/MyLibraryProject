using MyLibraryProject.Models;
using MyLibraryProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;

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

        public ActionResult Add()
        {
            var newBook = new Book();

            return View(newBook);
        }

        [HttpPost]
        public ActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                booksContext.Books.Add(book);
                booksContext.SaveChanges();

                return RedirectToAction("AllTheBooks");
            }

            return View(book);
        }

        public ActionResult Delete(int? bookId)
        {
            if (bookId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = booksContext.Books.Find(bookId);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int bookId)
        {
            Book book = booksContext.Books.Find(bookId);
            booksContext.Books.Remove(book);
            booksContext.SaveChanges();
            return RedirectToAction("AllTheBooks");
        }

        public ActionResult Edit(int? bookId)
        {
            if (bookId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = booksContext.Books.Find(bookId);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Title,Author,OnShelf")] Book book)
        {
            if (ModelState.IsValid)
            {
                booksContext.Entry(book).State = EntityState.Modified;
                booksContext.SaveChanges();
                return RedirectToAction("AllTheBooks");
            }
            return View(book);
        }
    }
}