using MyLibraryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLibrary.Models
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Genre[] Genres { get; set; }
        public string Description { get; set; }
        public int YearOfPublication { get; set; }
        public bool OnShelf { get; set; }
    }
}