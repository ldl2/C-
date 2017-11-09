using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;


namespace time.Controllers
{
    public class timeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            string s =
            ViewBag.Day = CurrentTime.ToString("MMM dd, yyyy");
            ViewBag.Time = CurrentTime.ToString("h:mm tt");
            return View();
        }
    }
}