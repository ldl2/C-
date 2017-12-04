using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Belt.Models.Validations;

namespace Belt.Models
{

	public class ValidateAuctionModel : BaseEntity	
	{
		[Display(Name="Product Name ")]
		[Required(ErrorMessage="First Name is requried")]
        [MinLength(3, ErrorMessage="Product name must be at least 3 characters long")]
		public string product {get; set;}

		[Required(ErrorMessage="Starting bid is requried")]
		[Display(Name="Starting Bid ")]
        [Range(0, Int32.MaxValue)]
		public double startingbid {get; set;}
		
        [Required(ErrorMessage="Username is required")]
        [MinLength(10, ErrorMessage="Description must be at least 10 characters long")]
        [Display(Name="Description ")]
        public string description {get; set;}
        
        [FutureDate(ErrorMessage="Date Must be a future date")]
        [DataType(DataType.Date)]
        [Display(Name="End Date")]
        public DateTime enddate {get; set;}

	}
}
