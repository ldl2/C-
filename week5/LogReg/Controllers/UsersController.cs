using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using LogReg.Models;

namespace LogReg.Controllers
{
    public class UsersController : Controller
    {
        private readonly DbConnector _dbConnector;
 
        public UsersController(DbConnector connect)
        {
            _dbConnector = connect;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index() => View("Index");

        [HttpPost]
        [Route("submit")]
        public IActionResult Register(Users user)
        {
            if(_dbConnector.Query(queryString: $"SELECT * FROM submission WHERE email='{user.email}'").Count>0)
            {
                ModelState.AddModelError(key: "email", errorMessage: "user exists");
            }
            if(ModelState.IsValid)
            {
                _dbConnector.Execute($"INSERT INTO submission (First_Name, Last_Name, Email, Password) VALUES ('{user.first_name}', '{user.last_name}', '{user.email}', '{user.password}')");
                return View("Registered");
            }
            return View("Index");
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(string email, string password)
        {
            Users user = new Users()
            {
                password = password,
                email = email,
                last_name = "tbd",
                first_name = "tbd",
            };
            System.Console.WriteLine(_dbConnector.Query($"SELECT * FROM submission WHERE email='{user.email}' AND password='{user.password}'").Count);

            if(_dbConnector.Query(queryString: $"SELECT * FROM submission WHERE email='{user.email}' AND password='{user.password}'").Count!=1)
            {
                ModelState.AddModelError(key: "email", errorMessage: "email/password combo does not exist");
            }
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet]
        [Route("success")]
        public IActionResult Success() => View("Success");
    }
}
