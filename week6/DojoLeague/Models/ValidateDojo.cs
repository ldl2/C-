using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DojoLeague.Models
{
	public class ValidateDojo : BaseEntity	
	{
		public ValidateDojo()
		{
			ValidateNinjas = new List<ValidateNinja>();
		}
		[Required(ErrorMessage="Name is required")]
		[Display(Name="Dojo Name:")]
		public string name {get; set;}
		[Required(ErrorMessage="Location is required")]
		[Display(Name="Dojo Location")]
		public string location {get; set;}
		[Display(Name="Additional Dojo Information")]
		public string info {get;set;}
		public ICollection<ValidateNinja> ValidateNinjas {get; set;}
	}
}
