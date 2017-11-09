using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;

namespace callingcard.Controllers
{
    public class callingcardController : Controller
    {
        // :5000/
        // :5000/hello/
        // :5000/hello/index
        [Route("")]
        public IActionResult Index() => View();

        [HttpPost]
        [Route("{FirstName}/{LastName}/{Age}/{FavoriteColor}")]
        public IActionResult Submit(string FirstName, string LastName, int Age, string FavoriteColor)
        {

            List<string> people = new List<string>();
            people.Add(FirstName);
            people.Add(LastName);
            people.Add(Age.ToString());
            people.Add(FavoriteColor);
            return Json(people);
        }
        [HttpGet]
        [Route("{FirstName}/{LastName}/{Age}/{FavoriteColor}")]
        public IActionResult TopBar(string FirstName, string LastName, int Age, string FavoriteColor)
        {

            List<string> people = new List<string>();
            people.Add(FirstName);
            people.Add(LastName);
            people.Add(Age.ToString());
            people.Add(FavoriteColor);
            return Json(people);
        }

    }
}