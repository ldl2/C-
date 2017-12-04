using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
	public abstract class BaseEntity {}
	public class ValidateUserModel : BaseEntity	
	{
		[Display(Name="First Name: ")]
		[Required(ErrorMessage="First Name is requried")]
		public string firstname {get; set;}

		[Required(ErrorMessage="Last name is requried")]
		[Display(Name="Last Name: ")]
		public string lastname {get; set;}
		
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
