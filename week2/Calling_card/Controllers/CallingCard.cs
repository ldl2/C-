using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Calling_card.Controllers
{
    public class CallingCardController : Controller
    {

    //:5000
    //:500/contorllername
    //:5000/contorllername/index
        public JsonResult Index(string FirstName, string LastName, int Age, string FavoriteColor)
        {
            List<string> person = new List<string>();
            person.Add(FirstName);
            person.Add(LastName);
            person.Add(Age.ToString());
            person.Add(FavoriteColor);
            return Json(person);
        }
        
    }
}
