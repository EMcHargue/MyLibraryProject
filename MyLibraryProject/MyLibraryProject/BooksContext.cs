using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyLibraryProject
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
                Books.Add(new Book { Title = "Pride and Prejudice", Author = "Jane Austen", OnShelf = false });
                Books.Add(new Book { Title = "The Other Boleyn Girl", Author = "Philippa Gregory", OnShelf = false });
                SaveChanges();
            }
        }
    }
}