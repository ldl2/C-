using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Restauranter.Models
{
	public class User : BaseEntity	
	{
		[Key]
		public int User_id {get; set;}
		public string name {get; set;}
		public string resteraunt {get; set;}
		public string review {get; set;}
		public DateTime visit {get;set;}
		public int stars { get; set;}
		public DateTime created_at=DateTime.Now;
		public DateTime updated_at=DateTime.Now;
	}
}
