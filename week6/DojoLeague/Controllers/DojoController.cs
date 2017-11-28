using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DojoLeague.Factory;
using DojoLeague.Models;

namespace DojoLeague.Controllers
{
    public class DojoController : Controller
    {
        private readonly ValidateDojoFactory dojoFactory;
        public DojoController(DbConnector connect)
        {
            dojoFactory = new ValidateDojoFactory();
        }
        // GET: /Home/
        [HttpGet]
        [Route("Dojos")]
        public IActionResult Dojos()
        {
            return View();
        }
        [HttpPost]
        [Route("CreateDojo")]
        public IActionResult CreateDojo(ValidateDojo newDojo)
        {
            if(ModelState.IsValid)
            {
                
            }
            return View("Dojos");
        }
    }
}

