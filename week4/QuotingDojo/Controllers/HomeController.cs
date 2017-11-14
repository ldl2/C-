using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;
using DbConnection;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index() => View("Index");
        
        [HttpGet]
        [Route("/Quotes")]
        public IActionResult Quotes(){
            List<Dictionary<string, object>> quotelist = DbConnector.Query("SELECT * FROM QuoteDB ORDER BY Created_at DESC");
            ViewBag.quotelist = quotelist;
            return View("Quotes");
        }

        [HttpPost]
        [Route("/Quotes")]
        public IActionResult QuotesSubmit(quoting Quoting)
        {
            if(ModelState.IsValid)
            {
                DbConnector.Execute($"INSERT INTO QuoteDB (Name, Quotes, Created_at) VALUES ('{Quoting.name}', '{Quoting.quote}', '{Quoting.time.ToString("yyyy-MM-dd HH:mm:ss")}')");
                List<Dictionary<string, object>> quotelist = DbConnector.Query("SELECT * FROM QuoteDB ORDER BY Created_at DESC");
                ViewBag.quotelist = quotelist;
                return View("Quotes");
            }
            else
                return View("Index");
        }
    }
}
