using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AjaxNotes.Models;
using DbConnection;

namespace AjaxNotes.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
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
                DbConnector.Execute(queryString: $"INSERT INTO Notes (Titles, Description, Created_at, Updated_at) VALUES ('{notes.title}', '{notes.description}', '{notes.made.ToString("yyyy-MM-dd HH:mm:ss")}', '{notes.edited.ToString("yyyy-MM-dd HH:mm:ss")}')");
                return View("/");
            }
            else
                return View("/");
        }

        [HttpPost]
        [Route("update/{id}/{Desc}")]
        public  IActionResult UpdateNote(int id, string Desc)
        {
            DateTime uptime = DateTime.Now;
            DbConnector.Execute($"UPDATE Notes SET Description={Desc}, Updated_at={uptime} WHERE id={id};");
            return View("/");
        }

        [HttpPost]
        [Route("delete/{id}")]
        public IActionResult DeleteNote(int id)
        {
            DbConnector.Execute($"DELETE FROM Notes WHERE id={id}");
            return View("/");
        }
    }
}
