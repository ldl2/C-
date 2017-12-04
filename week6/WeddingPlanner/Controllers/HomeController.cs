using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
    private UsersContext _context;
 
    public HomeController(UsersContext context)
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