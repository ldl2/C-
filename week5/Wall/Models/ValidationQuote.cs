using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wall.Models
{
    public class ValidationQuote :BaseEntity
    {
        [Required(ErrorMessage="Need a quote to submit here")]
        public string quote {get; set;}
        public int user_id {get; set;}
    }
}