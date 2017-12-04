using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Belt.Models
{
	public class LoginUser : BaseEntity	
	{
		[Required(ErrorMessage="Username must be included")]
        [Display(Name="Username")]
        public string username {get; set;}
        
        [Required(ErrorMessage="Users must include password")]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string password {get; set;}

	}
}
