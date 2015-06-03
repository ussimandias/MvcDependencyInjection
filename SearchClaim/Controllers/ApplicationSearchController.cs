using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SearchClaim.Models;




namespace SearchClaim.Controllers
{
    public class ApplicationSearchController : Controller
    {
        private readonly SearchClaim.Models.MockDependencyInjection.ISearchResultsService _resultsService;

        public ApplicationSearchController()
            : this(SearchClaim.Models.MockDependencyInjection.DependencyFactory.NewResultsService())
        {
            
        }

        public ApplicationSearchController(SearchClaim.Models.MockDependencyInjection.ISearchResultsService resultsService)
        {
            _resultsService = resultsService;

        }

        // GET: ApplicationSearch
        public ActionResult Index()
        {
            
            return View(_resultsService.FindClaims("", "", "", "", "", DateTimeOffset.Now, 123, "", 1234));
           
        }

        public ActionResult Search()
        {

            return View();

        }

        // GET: ApplicationSearch/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApplicationSearch/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicationSearch/Create
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

        // GET: ApplicationSearch/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApplicationSearch/Edit/5
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

        // GET: ApplicationSearch/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApplicationSearch/Delete/5
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
