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
            SeedData();
        }

        public void SeedData()
        {
            if (Books.Count() <= 0)
            {
                Books.Add(new Book { Title = "Dune", Author = "Frank Herbert", OnShelf = true });
                Books.Add(new Book { Title = "Pride and Prejudice", Author = "Jane Austen", OnShelf = true });
                Books.Add(new Book { Title = "The Other Boleyn Girl", Author = "Philippa Gregory", OnShelf = false });
                SaveChanges();
            }
        }
    }
}