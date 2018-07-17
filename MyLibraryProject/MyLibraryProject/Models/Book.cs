using MyLibraryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLibraryProject.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        //public Genre[] Genres { get; set; }
        public string Description { get; set; }
        //public int YearOfPublication { get; set; }
        public bool OnShelf { get; set; }
        public int Rating { get; set; }
    }
}