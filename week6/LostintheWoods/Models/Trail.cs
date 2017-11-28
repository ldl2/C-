using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LostintheWoods.Models
{
    public class Trail
    {
        [Key]
        public int id {get; set;}
        public string Name {get; set;}
        public string desc {get; set;}
        public double length {get; set;}
        public double elevation {get; set;}
        
        public string longitude {get; set;}
        
        public string latitude {get; set;}
        public DateTime created_at = DateTime.Now;
        public DateTime updated_at = DateTime.Now;

    }
}
