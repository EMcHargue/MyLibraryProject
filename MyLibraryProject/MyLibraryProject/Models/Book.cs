using MyLibraryProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyLibraryProject.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public Author Author { get; set; }
        //public Genre[] Genres { get; set; }
        public string Description { get; set; }
        //public int YearOfPublication { get; set; }
        public bool OnShelf { get; set; }
        [Range(0,5)]
        public int Rating { get; set; }
    }
}