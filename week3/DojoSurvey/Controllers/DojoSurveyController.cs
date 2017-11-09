using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace DojoSurvey.Controllers
{

    public class DojoSurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index() => View("index");

        [HttpGet]
        [Route("result")]
        public IActionResult Result()
        {
            ViewBag.name = TempData["name"];
            ViewBag.language = TempData["language"];
            ViewBag.location = TempData["location"];
            if(TempData["comment"] != null)
            {
                ViewBag.comment = TempData["comment"];
            }
            return View("result");
        } 

        [HttpPost]
        [Route("submit/{name}/{location}/{language}/{comment}")]
        public IActionResult Submit(string name, string location, string language, string comment)
        {
            ///validation doesn't work
            List<string> errors = new List<string>();
            if(name.Length < 1)
            {
                errors.Add("Must Include name");
            }
            else
            {
                TempData["name"] = name;
                System.Console.WriteLine(TempData["name"]);
            }

            if(location == null)
            {
                errors.Add("Must Include location");
            }
            else
            {
                TempData["location"] = location;
            }

            if(language == null)
            {
                errors.Add("Must Include language");
            }
            else
            {
                TempData["language"] = language;
            }

            if(comment != null)
            {
                TempData["comment"] = comment;
            }

            if(errors.Count >= 1)
            {
                //TempData["errors"] = errors;
                RedirectToAction("index");
            }
            return RedirectToAction("result");
        }
    }
}