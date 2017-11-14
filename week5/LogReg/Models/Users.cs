using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LogReg.Models
{
    public class Users{
            [MinLength(4)]
            [Required(ErrorMessage="Users must have first names")]
            [Display(Name="First Name")]
            public string first_name {get;set;}

            [MinLength(4)]
            [Display(Name="Last Name")]
            [Required(ErrorMessage="Users must have last names")]
            public string last_name {get;set;}


            [Required(ErrorMessage="Users must include email")]
            [EmailAddress]
            [Display(Name="Email Address")]
            public string email {get;set;}

            [Required(ErrorMessage="Users must include password")]
            [DataType(DataType.Password)]
            [Display(Name="Password")]
            public string password {get;set;}

            [Required(ErrorMessage="Users must include password")]
            [DataType(DataType.Password)]
            [Compare(nameof(password), ErrorMessage = " Passwords do not match")]
            [Display(Name="Confirm Password")]
            public string cpassword {get;set;}
    }
}
