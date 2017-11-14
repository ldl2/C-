using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AjaxNotes.Models;
using DbConnection;
using Newtonsoft.Json;

namespace AjaxNotes.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            List<Dictionary<string, object>> notelist = DbConnector.Query("SELECT * FROM NotesDB;");
            ViewBag.notelist = notelist;
            return View();
        }
        
        [HttpPost]
        [Route("add")]
        public IActionResult AddNote(Notes notes)
        {
            if(ModelState.IsValid)
            {
                
                DbConnector.Execute(queryString: $"INSERT INTO NotesDB (Titles, Description, Created_at, Updated_at) VALUES ('{notes.title}', '{notes.description}', '{notes.made.ToString("yyyy-MM-dd HH:mm:ss")}', '{notes.edited.ToString("yyyy-MM-dd HH:mm:ss")}')");
                return RedirectToRoute("/");
            }
            else
                return RedirectToRoute("/");
        }

        [HttpPost]
        [Route("update/{id}/{Desc}")]
        public  IActionResult UpdateNote(int id, string Desc)
        {
            DateTime uptime = DateTime.Now;
            DbConnector.Execute($"UPDATE NotesDB SET Description={Desc}, Updated_at={uptime} WHERE id={id};");
            return RedirectToRoute("/");
        }

        [HttpPost]
        [Route("delete/{id}")]
        public IActionResult DeleteNote(int id)
        {
            DbConnector.Execute($"DELETE FROM NotesDB WHERE id={id}");
            return RedirectToRoute("/");
        }
        [Route("hey")]
        public JsonResult heys()
        {
            return Json(new {success=true} );
        }
    }
}
