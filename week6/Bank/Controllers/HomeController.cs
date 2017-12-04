using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Bank.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Bank.Controllers
{
        public class HomeController : Controller
        {
        private UsersContext _context;
    
        public HomeController(UsersContext context)
        {
            _context = context;
        }
        public bool LoggedIN(int ids)
        {
            int myID = (int)HttpContext.Session.GetInt32("loggedID");
            if(ids == myID)
            {
                return true;
            }
            return false;
        }
        [HttpGet]
        [Route("account/{id}")]
        public IActionResult Index(int id)
        {
            if( LoggedIN(id)!=true)
            {
                return RedirectToAction("Login", "UserController");
            }
            User LoggedUser = _context.Users.Include(USER=>USER.Accounts).Where(User=>User.Userid==id).SingleOrDefault();
            ViewBag.acc = new ValidateAccountModel();
            return View("LoggedUser", LoggedUser);
        }
        [HttpPost]
        [Route("Deposit")]
        public IActionResult Deposit(ValidateAccountModel validateAccountModel)
        {
            validateAccountModel.balance += validateAccountModel.amount;
            if(validateAccountModel.balance<0)
            {
                ModelState.AddModelError("amount", "You don't have enough money to do that");
            }
            if(ModelState.IsValid)
            {
                Account deltaAccount = new Account()
                {
                    amount = validateAccountModel.amount,
                    balance = validateAccountModel.balance,
                    Userid = (int)HttpContext.Session.GetInt32("loggedID"),
                    user= _context.Users.SingleOrDefault(USER=>USER.Userid==(int)HttpContext.Session.GetInt32("loggedID"))
                };
                _context.Accounts.Add(deltaAccount);
                _context.SaveChanges();
                return View("LoggedUser", deltaAccount.Userid);
            }
            return View("LoggedUser");
        }

    }
}