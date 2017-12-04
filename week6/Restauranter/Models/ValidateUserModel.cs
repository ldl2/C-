using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Restauranter.Models
{
	public abstract class BaseEntity {}
	public class ValidateUserModel : BaseEntity	
	{
		[Display(Name="Reviewer Name: ")]
		[Required(ErrorMessage="Name is requried")]
		public string name {get; set;}

		[Required(ErrorMessage="Restaurant name is requried")]
		[Display(Name="Restaurant Name: ")]
		public string resteraunt {get; set;}
		
		[Display(Name="Review: ")]
		[Required(ErrorMessage="Review is requried")]
		[MinLength(10)]
		public string review {get; set;}
		
		[Required(ErrorMessage="Visit date is requried")]
		[Display(Name="Date of visit: ")]
		[RegularExpression("(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)[0-9]{2}", ErrorMessage="Formate dd/mm/yyyy")]
		public string visit {get;set;}
		
		[Display(Name="Stars: ")]
		[Required(ErrorMessage="Stars are requried")]
		[Range(0,5)]
		public int stars { get; set;}
	}
}
