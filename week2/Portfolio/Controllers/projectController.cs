using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;


namespace project.Controllers
{
    public class projectController : Controller
    {
        [HttpGet]
        [Route("")]
        public RedirectToActionResult Index() => RedirectToAction("Home");
        [HttpGet]
        [Route("Home")]
        public IActionResult Home() => View();
        [HttpGet]
        [Route("Projects")]
        public IActionResult Projects() => View();
        [HttpGet]
        [Route("Contact")]
        public IActionResult Contact() => View();
        [HttpPost]
        [Route("submit")]
        public IActionResult Submit() => RedirectToAction("Home");
    }
}