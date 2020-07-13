using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
  
namespace Bookstore.Models
{
    public class User
    {
        public string UserID {get; set;}
        [Required]
        [Display(Name = "Корисничко име")]
        public string Name { get; set; }
                
        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        [Display(Name = "Телефонски Број")]
        public string PhoneNumber { get; set; }
        
        [Display(Name = "Адреса на живеење")]
        public string Address { get; set; }
        
        [Display(Name = "Град")]
        public string City { get; set; }
        
        public int BookId {get; set;}
        [Display(Name = "Книга")]
        public Book Book {get; set;}
        #nullable enable
        [Display(Name = "Коментар")]
        public string? Comment {get; set;}
    }
}