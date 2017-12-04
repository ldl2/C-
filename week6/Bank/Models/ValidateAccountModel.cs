using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
	public class ValidateAccountModel : BaseEntity	
	{
		[Display(Name="Deposit/Withdraw: ")]
		[Required]
		public double amount {get; set;}

		[Required(ErrorMessage="Last name is requried")]
		[Display(Name="Last Name: ")]
		public double balance {get; set;}
	}
}
