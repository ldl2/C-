using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Wall.Models;

namespace Wall.Controllers
{
    public class UsersController : Controller
    {
        private readonly DbConnector _dbConnector;
        public UsersController(DbConnector connect)
        {
            _dbConnector = connect;
        }

        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        [HttpPost]
        [Route("submit")]
        public IActionResult Register(ValidationUsers user)
        {
            if(_dbConnector.Query(queryString: $"SELECT * FROM Users WHERE email='{user.email}'").Count>0)
            {
                ModelState.AddModelError(key: "email", errorMessage: "user exists");
            }
            if(ModelState.IsValid)
            {
                RegisterUserModel dbuser = new RegisterUserModel()
                {
                    name = user.name,
                    email = user.email,
                    password = user.password
                };
                _dbConnector.Execute($"INSERT INTO Users (name, email, password) VALUES ('{dbuser.name}', '{dbuser.email}', '{dbuser.password}')");
                return View("Registered");
            }
            return View("Index");
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(string email, string password)
        {
            RegisterUserModel user = new RegisterUserModel()
            {
                password = password,
                email = email,
                name = "tbd",
            };

            if(_dbConnector.Query(queryString: $"SELECT * FROM Users WHERE email='{user.email}' AND password='{user.password}'").Count!=1)
            {
                ModelState.AddModelError(key: "email", errorMessage: "email/password combo does not exist in database");
            }
            if(ModelState.IsValid)
            {
                List<Dictionary<string, object>> forname = _dbConnector.Query($"SELECT name FROM Users WHERE email='{user.email}'");
                List<Dictionary<string, object>> forid = _dbConnector.Query($"SELECT id FROM Users WHERE email='{user.email}'");
                HttpContext.Session.SetString("name", (string)forname[0]["name"]);
                HttpContext.Session.SetInt32("id", (int)forid[0]["id"]);
                return RedirectToAction("Quotes");
            }
            else
            {
                return View("Index");
            }
            
        }
        [HttpGet]
        [Route("/Quotes")]
        public IActionResult Quotes(){
            ViewBag.id=HttpContext.Session.GetInt32("id");
            ViewBag.currentname=HttpContext.Session.GetString("name");
            List<Dictionary<string, object>> quotelist = _dbConnector.Query("SELECT Quotes.id, Quotes.quote, Quotes.created_at, Users.name FROM WallDB.Quotes JOIN WallDB.Users ON Quotes.user_ID = WallDB.Users.id ORDER BY WallDB.Quotes.Created_at DESC");
            ViewBag.quotelist = quotelist;
            List<Dictionary<string, object>> commentlist = _dbConnector.Query("SELECT Comments.comment, Comments.created_at, Comments.quote_id, Users.name  FROM WallDB.Comments JOIN WallDB.Users ON Comments.user_id = WallDB.Users.id ORDER BY WallDB.Comments.Created_at ");
            ViewBag.commentlist = commentlist;
            return View("Wall");
        }

        [HttpPost]
        [Route("/Quotes")]
        public IActionResult QuotesSubmit(ValidationQuote Quoting)
        {
            if(ModelState.IsValid)
            {
                RegisterQuoteModel quote = new RegisterQuoteModel(){
                    quote =Quoting.quote,
                    user_id = Quoting.user_id,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                _dbConnector.Execute($"INSERT INTO Quotes (quote, user_id, created_at, updated_at) VALUES ('{quote.quote}', '{quote.user_id}', '{quote.created_at.ToString("yyyy-MM-dd HH:mm:ss")}', '{quote.updated_at.ToString("yyyy-MM-dd HH:mm:ss")}')");
                return RedirectToAction("Quotes");
            }
            else
                return RedirectToAction("Quotes");
        }
        [HttpPost]
        [Route("/Comments")]
        public IActionResult CommentSubmit(ValidationComment commenting)
        {
            if(ModelState.IsValid)
            {
                RegisterCommentModel comment = new RegisterCommentModel(){
                    comment =commenting.Comment,
                    user_id = commenting.user_id_comment,
                    quote_id = commenting.quote_id,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                _dbConnector.Execute($"INSERT INTO Comments (comment, quote_id, user_id, created_at, updated_at) VALUES ('{comment.comment}', '{comment.quote_id}', '{comment.user_id}', '{comment.created_at.ToString("yyyy-MM-dd HH:mm:ss")}', '{comment.updated_at.ToString("yyyy-MM-dd HH:mm:ss")}')");
                return RedirectToAction("Quotes");
            }
            else
                return RedirectToAction("Quotes");
        }
    }
}

