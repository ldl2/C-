using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
	public class User : BaseEntity	
	{
		[Key]
		public int Userid {get; set;}
		public string firstname {get; set;}
		public string lastname {get; set;}
		public string email {get; set;}
		public string password { get; set;}
		public DateTime created_at=DateTime.Now;
		public DateTime updated_at=DateTime.Now;
		public List<Account> Accounts {get;set;}
		public User()
		{
			Accounts=new List<Account>();
		}

	}
    public class WeddingPlanner
    {

    }
}
