using MyLibraryProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyLibraryProject.Data
{
    internal class DatabaseInitializer : DropCreateDatabaseAlways<BooksContext>
    {
        protected override void Seed(BooksContext context)
        {
            // Database seed data

            var Book1 = new Book()
            {
                Title = "Dune",
                Author = new Author() { FirstName = "Frank", LastName = "Herbert" },
                OnShelf = true,
                Rating = 4
            };
            context.Books.Add(Book1);

            var Book2 = new Book()
            {
                Title = "Pride and Prejudice",
                Author = new Author () { FirstName = "Jane", LastName = "Austen" },
                OnShelf = true,
                Rating = 4
            };
            context.Books.Add(Book2);

            var Book3 = new Book()
            {
                Title = "The Other Boleyn Girl",
                Author = new Author () { FirstName = "Philippa", LastName = "Gregory"},
                OnShelf = false,
                Rating = 1
            };
            context.Books.Add(Book3);

            context.SaveChanges();

        }
    }
}
