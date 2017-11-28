using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using LostintheWoods.Factory;
using LostintheWoods.Models;

namespace LostintheWoods.Controllers
{
    public class HomeController : Controller
    {
	private readonly ValidateTrailFactory validatetrailfactory;
 
        public HomeController(DbConnector connect)
        {
            validatetrailfactory = new ValidateTrailFactory();
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.TrailsTable = validatetrailfactory.FindAll();
            return View();
        }

        [HttpGet]
        [Route("Add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        [Route("trails/{id}")]
        public IActionResult Details(int id)
        {
            ViewBag.details = validatetrailfactory.FindByID(id);
            return View();
        }

        [HttpPost]
        [Route("CreateNewTrail")]
        public IActionResult Create(ValidateTrail Trails)
        {
            if(ModelState.IsValid)
            {
                Trail dbtrail = new Trail()
                {
                    Name = Trails.name,
                    desc = Trails.desc,
                    length = Trails.length,
                    elevation = Trails.elevation,
                    longitude = Trails.longitude,
                    latitude = Trails.latitude,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                validatetrailfactory.Added(dbtrail);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Add");
            }
        }
    }
}