using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Infinterest.Models
{
   public class UserValidator
    {   
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "A type is required")]
        public string UserType {get; set;}

        [DataType(DataType.Text)]
        [Display(Name = "First Name:")]
        [RegularExpression("^([a-zA-Z ]*)$"), StringLength(45, MinimumLength = 2)]
        [Required(ErrorMessage = "Your first name is required")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Your last name is required")]
        [MinLength(2, ErrorMessage = "Your last name has to be at least 2 letters")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Your last name must consist of letters only")]
        public string LastName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Contact Name:")]
        public string Contact { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Your bio:")]
        public string Bio { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Your email is required")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        [Required(ErrorMessage = "A password is required")]
        // [RegularExpression("^(?=.*[a-zA-Z])(?=.*[^a-zA-Z])(.{8,15})$", ErrorMessage = "Your password must contain an upper case letter, lower case letter, and special character or number")]
        // [RegularExpression("^(?=.*[a-zA-Z])(?=.*[0-9])(.{8,15})$", ErrorMessage = "Your password must contain an upper case letter, lower case letter, and special character or number")]
        // [RegularExpression("^(?=.*[a-zA-Z])(?=.*[0-9])(.{8,15})$", ErrorMessage = "Your password must contain an upper case letter, lower case letter, and special character or number")]
        // [MinLength(8, ErrorMessage = "Your password must be at least 8 characters long")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm your password:")]
        [Required(ErrorMessage = "A password is required")]
        [Compare(nameof(Password), ErrorMessage = "Your passwords need to match")]        
        public string PasswordConfirm { get; set; }
    }

   
}