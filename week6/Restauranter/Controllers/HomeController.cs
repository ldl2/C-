using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Restauranter.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace Restauranter.Controllers
{
    public class HomeController : Controller
    {
        private VisitsContext _visitsContext;
    
        public HomeController(VisitsContext visitscontext)
        {
            _visitsContext = visitscontext;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<User> AllUsers = _visitsContext.Users.ToList();
            return View();
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(ValidateUserModel vum)
        {
            if (ModelState.IsValid)
            {
                User forreview = new User()
                {
                    name = vum.name,
                    resteraunt = vum.resteraunt,
                    review = vum.review,
                    visit = Convert.ToDateTime(vum.visit),
                    stars = vum.stars
                };
                _visitsContext.Add(forreview);
                _visitsContext.SaveChanges();
                return RedirectToAction("Reviews");
            }
            return View("Index");
        }
        [HttpGet]
        [Route("Reviews")]
        public IActionResult Reviews()
        {
            IEnumerable<User> MyUsers = _visitsContext.Users.OrderByDescending(USER =>USER.created_at);
            System.Console.WriteLine(MyUsers);
            ViewBag.MyUsers = MyUsers;
            return View();
        }
    }
}