using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Belt.Models
{
	public class User : BaseEntity	
	{
		[Key]
		public int Userid {get; set;}
		public string firstname {get; set;}
		public string lastname {get; set;}
		public string username {get; set;}
		public string password { get; set;}
		public double wallet {get;set;}
		public DateTime created_at=DateTime.Now;
		public DateTime updated_at=DateTime.Now;
		public List<Auction> Auctions {get;set;}
		public List<Bid> Bids {get;set;}
		public User()
		{
			Auctions=new List<Auction>();
			Bids=new List<Bid>();
		}

	}
	public class Auction: BaseEntity
	{
		[Key]
		public int Auctionid {get;set;}
		public string product {get;set;}
		public double startingbid {get; set;}
		public DateTime enddate {get; set;}
		public string description{get;set;}
		public User user {get;set;}
		public int Userid {get;set;}
		public DateTime created_at=DateTime.Now;
		public DateTime updated_at=DateTime.Now;
		public List<Bid> Bids{get;set;}
		public Auction()
		{
			Bids=new List<Bid>();
		}

	}
	public class Bid: BaseEntity
	{
		public int Bidid {get;set;}
		public double amount{get;set;}
		public Auction auction {get;set;}
		public int Auctionid {get;set;}
		public User user {get;set;}
		public int Userid {get;set;}
		public DateTime created_at=DateTime.Now;
		public DateTime updated_at=DateTime.Now;
	}
}
