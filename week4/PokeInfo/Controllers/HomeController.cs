using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace PokeInfo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("pokemon/{pokeid}")]
        public async Task<IActionResult> Index(int pokeid)
        {
            Pokemon PokeData;
            await WebRequest.GetPokemonDataAsync(pokeid, data =>
                {
                    PokeData = data;
                    ViewBag.Pokemon = PokeData;
                }
            );
            return View();
        }
    }
}

