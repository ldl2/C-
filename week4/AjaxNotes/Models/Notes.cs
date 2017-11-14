using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AjaxNotes.Models
{
    public class Notes
    {
        [Required(ErrorMessage="Notes must have titles")]
        public string title {get; set;}
        public string description = "Enter description here...";

        public DateTime made = DateTime.Now;
        public DateTime edited = DateTime.Now;


    }
}
