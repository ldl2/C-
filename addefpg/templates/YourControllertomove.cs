using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using namespace.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Yournamespace.Controllers
{
    public class YourController : Controller
    {
    private YourContext _context;
 
    public YourController(YourContext context)
    {
        _context = context;
    }
    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        List<Person> AllUsers = _context.Users.ToList();
        // Other code
    }
}