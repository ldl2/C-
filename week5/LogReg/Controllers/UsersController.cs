using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using LogReg.Models;
using DbConnection;

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
        [Route("submist")]
        public IActionResult Submit(Users user)
        {
            if(ModelState.IsValid)
            {
                _dbConnector.Execute($"INSERT INTO submission (First_Name, Last_Name, Email, Password) VALUES ('{user.first_name}', '{user.last_name}', '{user.email}', '{user.password}')");
                return View("Success");
            }
            return View("Index");
        }

        [HttpGet]
        [Route("sucess")]
        public IActionResult sucess() => View("Success");
    }
        
}
