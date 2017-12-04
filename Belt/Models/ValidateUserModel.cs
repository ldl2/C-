using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Belt.Models
{
	public abstract class BaseEntity {}
	public class ValidateUserModel : BaseEntity	
	{
		[Display(Name="First Name ")]
		[Required(ErrorMessage="First Name is requried")]
		public string firstname {get; set;}

		[Required(ErrorMessage="Last name is requried")]
		[Display(Name="Last Name ")]
		public string lastname {get; set;}
		
        [Display(Name="Username ")]
        [Required(ErrorMessage="Username is required")]
        [MinLength(3, ErrorMessage="Usernames must be at least 3 characters long")]
        [MaxLength(20, ErrorMessage="Usernames cannot be more than 20 characters long")]
        public string username {get; set;}
        
        [Required(ErrorMessage="Users must include password")]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        [MinLength(8, ErrorMessage="Passwords must be at least 8 characters long")]
        public string password {get; set;}

        [Required(ErrorMessage="Users must include password")]
        [DataType(DataType.Password)]
        [Compare(nameof(password), ErrorMessage = " Passwords do not match")]
        [Display(Name="Confirm Password")]
        public string cpassword {get; set;}
	}
}
