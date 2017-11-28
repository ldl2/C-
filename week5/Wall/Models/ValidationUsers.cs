using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wall.Models
{
    public class ValidationUsers :BaseEntity
    {
        [MinLength(4)]
        [Required(ErrorMessage="Users must have first names")]
        [Display(Name="Name")]
        public string name {get; set;}

        [Required(ErrorMessage="Users must include email")]
        [EmailAddress]
        [Display(Name="Email Address")]
        public string email {get; set;}
        
        [Required(ErrorMessage="Users must include password")]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string password {get; set;}

        [Required(ErrorMessage="Users must include password")]
        [DataType(DataType.Password)]
        [Compare(nameof(password), ErrorMessage = " Passwords do not match")]
        [Display(Name="Confirm Password")]
        public string cpassword {get; set;}
    }
}

