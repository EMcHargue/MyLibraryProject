using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyLibraryProject.Models;

namespace MyLibraryProject.Data
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BooksContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        static BooksContext GetContext()
        {
            var context = new BooksContext();
//            context.Database.Log = (message) => Debug.WriteLine(message);
            return context;
        }

        public Book GetBook(int BookId)
        {
            using (BooksContext context = GetContext())
            {
                return context.Books
                    .Where(b => b.Id == BookId)
                    .SingleOrDefault();
            }
        }
    }
}