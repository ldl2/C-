using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DojoLeague.Models
{
	public abstract class BaseEntity {}
	public class ValidateNinja : BaseEntity	
	{
		[Required(ErrorMessage="Name is required")]
		[Display(Name="Ninja Name:")]
		public string name {get; set;}
		[Required(ErrorMessage="level is required")]
		[Range(1,10)]
		[Display(Name="Ninjaing Level (1-10)")]
		public int level {get; set;}
		[Display(Name="Assigned Dojo")]
		public ValidateDojo dojo {get;set;}
		[Display(Name="Optional Description")]
		public string description {get;set;}
	}
}
