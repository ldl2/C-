using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RanPass.Models;

namespace RanPass.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            int? Counter = HttpContext.Session.GetInt32("counter");
            if(Counter == null)
            {
                Counter = 0;
            }
            Counter++;
            HttpContext.Session.SetInt32("counter", (int)Counter);
            ViewBag.count = Counter;


            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[14];

            Random randomy = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[randomy.Next(chars.Length)];
            }

            ViewBag.rand =  new string(stringChars);
            return View("Index");
        }
        [HttpPost]
        [Route("submit")]
        public IActionResult Submit()
        {
            TempData["count"] = ViewBag.count + 1;
            return RedirectToAction("Index");
        }
    }
}
