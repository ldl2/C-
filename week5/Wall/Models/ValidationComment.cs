using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wall.Models
{
    public class ValidationComment :BaseEntity
    {
        [Required(ErrorMessage="Need a quote to submit here")]
        public string Comment {get; set;}
        public int user_id_comment {get; set;}
        public int quote_id {get; set;}
    }
}