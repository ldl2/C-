using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DojoLeague.Models
{
    public class DLDojo
    {
        [Key]
        public int id {get;set;}
        public string name {get;set;}
        public string location{get;set}
        public string info{get;set}
        public DateTime created_at = DateTime.Now;
        public DateTime updated_at = DateTime.Now;
    }
    public class DLNinja
    {
        [Key]
        public int id {get;set;}
        public string name {get;set;}
        public int level {get;set;}
        public string dojo {get;set;}
        public DateTime created_at = DateTime.Now;
        public DateTime updated_at = DateTime.Now;
    }
    
}