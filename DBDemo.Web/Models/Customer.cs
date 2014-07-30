using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DBDemo.Web.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        
        [Required]
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        
        [Required]
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        
        [Required]
        [Display(Name = "Employer")]
        [DataType(DataType.Text)]
        public string CompanyName { get; set; }
        
        // NOT REQUIRED -- ADDRESS INFORMATION
        [Display(Name = "Street Address")]
        [DataType(DataType.Text)]
        public string Address { get; set; }
        
        [Display(Name = "City")]
        [DataType(DataType.Text)]
        public string City { get; set; }
        
        [Display(Name = "State")]
        [DataType(DataType.Text)]
        public string State { get; set; }
        
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        public string Zip { get; set; }


        [Required]
        [Phone]
        [StringLength(14, ErrorMessage = "Phone number may only be 10 to 14 characters long", MinimumLength = 10)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


    }
}