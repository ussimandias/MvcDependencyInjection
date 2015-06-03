using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using JarvisMVC.Models;
using SearchClaim.Models;

namespace SearchClaim.Controllers
{
    public class FooController : Controller
    {

        public PartialViewResult LatestReview(SearchCriteria newClaim)
        {
            var noClaim = new List<SearchCriteria>();

            var claim = new SearchCriteria() { Account = 123, FirstName = "Test", EffectiveDate = DateTimeOffset.Now, LoanNumber = 123, LastName = "Test", CertificateNumber = "Test", ClaimNumber = "Test", CompanyName = "Test", Creditor = "Bank of America" };

            Thread.Sleep(2000);

            if (Session["dataEntry"] != null)
            {
                noClaim= (List<SearchCriteria>)Session["dataEntry"];
            }


            noClaim.Add(newClaim);
            Session["dataentry"] = noClaim;

            if (ModelState.IsValid)
            {
                return PartialView("LatestReview");
            }
            else
            {
                return PartialView();
            }     
            
        }

        // GET: Foo
        public ActionResult Index()
        {
            Thread.Sleep(2000);
            var claim = new SearchCriteria(){Account = 123, FirstName = "Test", EffectiveDate = DateTimeOffset.Now, LoanNumber = 123, LastName = "Test", CertificateNumber = "Test", ClaimNumber = "Test", CompanyName = "Test", Creditor = "Bank of America"};

            return View(claim);
        }

        //[HttpGet]
        //public ActionResult Index()
        //{
            
        //    return View();
        //}

        [HttpPost]
        public ActionResult Create(SearchCriteria claim)
        {
            claim.FirstName = "Tester";
            claim.LastName = "Test";
            claim.ClaimNumber = "Test";
            claim.EffectiveDate = DateTimeOffset.Now;
            claim.Account = 123;
            claim.Creditor = "Wells Fargo";
            claim.LoanNumber = 123;

                

            return View(claim);
        }





        // GET: Foo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Foo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Foo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Foo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Foo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Foo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Foo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
