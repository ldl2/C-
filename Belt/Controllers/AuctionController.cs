using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Belt.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace Belt.Controllers
{
    public class AuctionController : Controller
    {
        private UsersContext _context;
        private User ActiveUser
        {
            get {
                return _context.Users.SingleOrDefault(
                    USER => USER.Userid == (int)HttpContext.Session.GetInt32("loggedID")
                );
            }
        }
        public AuctionController(UsersContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("new")]
        public IActionResult New()
        {
            if(ActiveUser == null)
                return RedirectToAction("Index", "User");
            return View();
        }

        [HttpGet]
        [Route("logout")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "User");
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(ValidateAuctionModel validateAuctionModel)
        {
            if(ModelState.IsValid)
            {
                Auction newAuction = new Auction()
                {
                    product=validateAuctionModel.product,
                    startingbid=validateAuctionModel.startingbid,
                    description=validateAuctionModel.description,
                    enddate=validateAuctionModel.enddate,
                    user=ActiveUser,
                };
                _context.Auctions.Add(newAuction);
                _context.SaveChanges();
                return RedirectToAction("Show", new {id=newAuction.Auctionid});
            }
            return View("New");
        }

        [HttpGet]
        [Route("current")]
        public IActionResult Current()
        {
            if (ActiveUser == null)
                return RedirectToAction("Index", "User");
            List<User> chartAuction = _context.Users.Include(USER => USER.Auctions).ToList();
            foreach (User today in chartAuction)
            {
                foreach(Auction now in today.Auctions)
                {
                    if(now.enddate <= DateTime.Now)
                    {
                    if (today.Bids.Count != 0)
                    {
                        //meh will do the job but there is no verification to make sure over
                        //bidding will not allow wallet to go negative would be better with
                        //1 more class that acts as pending sales
                        now.Bids[now.Bids.Count - 1].user.wallet -= now.startingbid;
                        today.wallet += now.startingbid;
                    }
                    _context.Auctions.Remove(now);
                    _context.SaveChanges();
                }
                }
                
            }
            @ViewBag.chartAuction = chartAuction;
            return View(ActiveUser);
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            if(ActiveUser == null)
                return RedirectToAction("Index", "User");
            Auction viewAuction = _context.Auctions.Where(AUCTION=>AUCTION.Auctionid==id).SingleOrDefault();
            _context.Auctions.Remove(viewAuction);
            _context.SaveChanges();
            return RedirectToAction("Current");
        }

        [HttpGet]
        [Route("show/{id}")]
        public IActionResult Show(int id)
        {
            if(ActiveUser == null)
                return RedirectToAction("Index", "User");
            HttpContext.Session.SetInt32("return", id);
            Auction viewAuction = _context.Auctions.Where(AUCTION=>AUCTION.Auctionid==id).Include(USER =>USER.user).Include(BIDS => BIDS.Bids).SingleOrDefault();
            if(viewAuction.Bids.Count>0)
            {
                ViewBag.big =viewAuction.Bids[viewAuction.Bids.Count-1].user.firstname;
            }
            else
            {
                ViewBag.big=0;
            }
            ViewBag.bid = new ValidateBidModel();
            return View(viewAuction);
        }

        [HttpPost]
        [Route("Bid")]
        public IActionResult Bid(ValidateBidModel validateBidModel)
        {
            System.Console.WriteLine(validateBidModel.amount);
            int? needed = HttpContext.Session.GetInt32("return");
            System.Console.WriteLine(needed);
            Auction ActiveAuction = _context.Auctions.SingleOrDefault(USER => USER.Auctionid == needed);
            
            if(ActiveAuction.enddate <= DateTime.Now)
            {
                ModelState.AddModelError("amount", "Bidding is over");
            }
            if(ActiveAuction.startingbid>validateBidModel.amount||ActiveUser.wallet<validateBidModel.amount)
            {
                ModelState.AddModelError("amount", "Your must bid higher than the active bid or User doesn't have enough money for that");
            }
            else
            {
                ActiveAuction.startingbid=validateBidModel.amount;
            }
            if(ModelState.IsValid)
            {
                Bid fresh = new Bid()
                {
                    amount = validateBidModel.amount,
                    user=ActiveUser,
                    Userid=ActiveUser.Userid,
                    auction =ActiveAuction,
                    Auctionid=ActiveAuction.Auctionid
                };
                _context.Bids.Add(fresh);
                _context.SaveChanges();
                return RedirectToAction("Show", new {id=needed});}
            Auction viewAuction = _context.Auctions.Where(AUCTION=>AUCTION.Auctionid==needed).Include(USER =>USER.user).Include(BIDS => BIDS.Bids).SingleOrDefault();
            
            if(viewAuction.Bids.Count>0)
            {
                ViewBag.big =viewAuction.Bids[viewAuction.Bids.Count-1].user.firstname;
            }
            else
            {
                ViewBag.big=0;
            }
            ViewBag.bid = new ValidateBidModel();
            return View("Show", viewAuction);
        }
    }
}