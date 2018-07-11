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
                Author = "Frank Herbert",
                OnShelf = true
            };
            context.Books.Add(Book1);

            var Book2 = new Book()
            {
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                OnShelf = true
            };
            context.Books.Add(Book2);

            var Book3 = new Book()
            {
                Title = "The Other Boleyn Girl",
                Author = "Philippa Gregory",
                OnShelf = false
            };
            context.Books.Add(Book3);

            context.SaveChanges();
        }
    }
}
