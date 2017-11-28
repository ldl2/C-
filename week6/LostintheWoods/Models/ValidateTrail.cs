using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LostintheWoods.Models.Validations;

namespace LostintheWoods.Models
{
    public abstract class BaseEntity {}
    public class ValidateTrail : BaseEntity
    {

        [Required(ErrorMessage="Name is required")]
        [Display(Name = "Trail Name")]
        public string name {get; set;}

        [Required(ErrorMessage="Description must be 10 chars")]
        [MinLength(10, ErrorMessage="Description must be 10 chars")]
        [Display(Name = "Description")]
        public string desc {get; set;}
        
        [DoubleAttributes]
        [Display(Name ="Trail Length")]
        
        public double length {get; set;}
        
        [DoubleAttributes]
        [Display(Name ="Elevation Change")]
        public double elevation {get; set;}

        [RegularExpression(@"[0-9]?[0-9]?[0-9]\.[0-9][0-9][0-9][0-9]", ErrorMessage="Must match pattern XXX.XXX where X=0-9")]
        [Display(Name ="Longitude & Latitude")]
        public string longitude {get; set;}

        [RegularExpression(@"[0-9]?[0-9]?[0-9]\.[0-9][0-9][0-9][0-9]", ErrorMessage="Must match pattern XXX.XXX where X=0-9")]
        public string latitude {get; set;}

    }
}
