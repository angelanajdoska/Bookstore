using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Models
{
    public class Author
    {

        public string Picture { get; set; }
        [Required]
        [Key]
        public int AuthorID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime DateofBirth { get; set; }
        [Display(Name = "Date of Death")]
        public DateTime? DateofDeath { get; set; }
        public string Biography { get; set; }
        public int BooksId { get; set; }
        public string Rewards { get; set; }
        
        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        [ForeignKey("BooksId")]
        public Book Books { get; set; }
        public ICollection<Book> Book {get; set;}
    }
}