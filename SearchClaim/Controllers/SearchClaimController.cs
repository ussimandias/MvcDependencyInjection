using SearchClaim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchClaim.Controllers
{
    public class SearchClaimController : Controller
    {
        // GET: SearchClaim
        public ActionResult Index()
        {
            var booksCollection = new List<Book>();

            if (Session["BooksCollection"] != null)
            {
                booksCollection = (List<Book>)Session["BooksCollection"];
            }

            return View(booksCollection);
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string searchbtn)
        {
            return PartialView( );
        }

        [HttpGet]
        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(Book newbook)
        {
            var BooksCollection = new List<Book>();

            if (Session["BooksCollection"] != null)
            {
                BooksCollection = (List<Book>)Session["BooksCollection"];

            }

            BooksCollection.Add(newbook);
            Session["BooksCollection"] = BooksCollection;

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
                     
        }
    }
}