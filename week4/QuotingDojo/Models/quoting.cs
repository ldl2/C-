using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models
{
    public class quoting
    {
        [Required(ErrorMessage="You must put in a name")]
        [Display(Name="Your Name")]
        public string name {get;set;}

        [Required(ErrorMessage="You must put in a quote")]
        [Display(Name="Your Quote")]
        public string quote {get;set;}

        public DateTime time = DateTime.Now;
    }

}