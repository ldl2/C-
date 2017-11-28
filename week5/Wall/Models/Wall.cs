using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wall.Models
{
    public class RegisterUserModel : BaseEntity
    {
        [Key]
        public int id {get;set;}
        public string name {get; set;}
        public string email {get; set;}
    
        public string password {get; set;}
        public DateTime updated_at = DateTime.Now;
        public DateTime created_at = DateTime.Now;
    }
    public class RegisterQuoteModel : BaseEntity
    {
        [Key]
        public int id {get; set;}
        [Key]
        public int user_id {get; set;}
        
        public string quote {get; set;}
        public DateTime updated_at = DateTime.Now;
        public DateTime created_at = DateTime.Now;

    }
        public class RegisterCommentModel : BaseEntity
    {
        [Key]
        public int id {get; set;}
        [Key]
        public string comment {get; set;}
        public int quote_id {get; set;}
        public int user_id {get; set;}

        public DateTime created_at = DateTime.Now;
        public DateTime updated_at = DateTime.Now;

    }
}
