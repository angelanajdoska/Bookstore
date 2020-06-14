using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore.Models
{
    public class Movie
    {

        public string Picture { get; set; }
        [Required]
        [Key]
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int BookId { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Synopsis { get; set; }
        public string Trailer { get; set; }
        public string Rating { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
        
    }
}