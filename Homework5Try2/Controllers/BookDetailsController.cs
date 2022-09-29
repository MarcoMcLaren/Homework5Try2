using Homework5Try2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Homework5Try2.Controllers
{
    public class BookDetailsController : Controller
    {
        private readonly LibraryEntities db = new LibraryEntities();

        // GET: BookDetails
        //public ActionResult Index(/*int? bookId*/)
        //{
        //if (bookId == null)
        //{
        //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //}
        //books books = db.books.Find(bookId);

        //var booksDetails = new BookDetailsVM
        //{
        //    books = db.books.ToList().Where(x => x.bookId == bookId),
        //    borrows = db.borrows.ToList(),
        //    students = db.students.ToList(),
        //};
        //if (books == null)
        //{
        //    return HttpNotFound();
        //}
        //return View(booksDetails);
        //}

        [HttpGet]
        public ActionResult Index(int id)
        {
            var borrows = db.borrows.Where(x => x.bookId == id).ToList();
            return View(borrows);
        }
        //[HttpPost]
        //public ActionResult Index(int? bookId)
        //{
        //    var borrow = db.books.ToList().Where(x => x.bookId == 1);
        //    return View(borrow);
        //}
    }
}