using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Bank.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace Bank.Controllers
{
    public class UserController : Controller
    {
        private UsersContext _context;
    
        public UserController(UsersContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(ValidateUserModel validateUserModel)
        {
            if(ModelState.IsValid)
            {
                PasswordHasher<ValidateUserModel> temp = new PasswordHasher<ValidateUserModel>();
                validateUserModel.password=temp.HashPassword(validateUserModel, validateUserModel.password);

                User newUser = new User()
                {
                    firstname=validateUserModel.firstname,
                    lastname=validateUserModel.lastname,
                    email=validateUserModel.email,
                    password=validateUserModel.password
                };
                _context.Users.Add(newUser);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home", new {id=newUser.Userid});
            }
            return View("Index");
        }

        [HttpPost]
        [Route("Signin")]
        public IActionResult SignIn(LoginUser loginUser)
        {
            User logUser = _context.Users.Where(USER =>USER.email == loginUser.email).SingleOrDefault();
            var Hasher = new PasswordHasher<User>();
            if(0 != Hasher.VerifyHashedPassword(logUser, logUser.password, loginUser.password))
            {
                if(ModelState.IsValid)
                {
                    System.Console.WriteLine("logUser.Userid");
                    HttpContext.Session.SetInt32("loggedID", logUser.Userid);
                    return RedirectToAction("Index", "Home", new {id=logUser.Userid});
                }
                else
                {
                    return View("Login");
                }
            }
            else
            {
                ModelState.AddModelError("password", "email/password combo does not exist");
                return View("Login");
            }
        }
    }
}