using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
	public class LoginUser : BaseEntity	
	{
		[Required(ErrorMessage="Users must include email")]
        [EmailAddress]
        [Display(Name="Email Address")]
        public string email {get; set;}
        
        [Required(ErrorMessage="Users must include password")]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string password {get; set;}

	}
}
