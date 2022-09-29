using Homework5Try2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework5Try2.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryEntities db = new LibraryEntities();
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.TypesDropdown = new SelectList(db.types.Select(m => m.name).Distinct().ToString());
            var books = db.books.ToList();
            return View(books);
        }
        [HttpPost]
        public ActionResult Index(string searchtext)
        {
            var books = db.books.Where(x => x.name.Contains(searchtext)).ToList();
            return View(books);
        }
      
    }
}