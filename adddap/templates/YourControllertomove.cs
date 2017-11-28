using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using namespace.Factory;
using namespace.Models;

namespace Yournamespace.Controllers
{
    public class HomeController : Controller
    {
	private readonly yourfactory factoryinstance;;
 
        public YourController(DbConnector connect)
        {
            factoryinstance = new yourfactory();
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
