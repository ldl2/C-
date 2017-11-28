using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DojoLeague.Factory;
using DojoLeague.Models;

namespace DojoLeague.Controllers
{
    public class NinjaController : Controller
    {
        private readonly ValidateNinjaFactory ninjaFactory;
        public NinjaController(DbConnector connect)
        {
            ninjaFactory = new ValidateNinjaFactory();
        }
        // GET: /Home/
        [HttpGet]
        [Route("Ninjas")]
        public IActionResult Ninjas()
        {
            return View();
        }
    }
}

