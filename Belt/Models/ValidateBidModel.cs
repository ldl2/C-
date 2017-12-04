using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Belt.Models.Validations;

namespace Belt.Models
{

	public class ValidateBidModel : BaseEntity	
	{
		[Required(ErrorMessage="Bid is required")]
		[Range(0,Int32.MaxValue)]
		public double amount {get; set;}

		

	}
}
