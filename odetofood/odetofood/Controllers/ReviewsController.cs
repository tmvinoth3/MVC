using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odetofood.Models;

namespace odetofood.Controllers
{
    public class ReviewsController : Controller
    {
        FoodDb _db = new FoodDb();
        //
        // GET: /Reviews/

        public ActionResult Index()
        {
            var model = _db.findLatest(3);
            return View(model);
        }

        //
        // GET: /Reviews/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reviews/Create
        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection c)
        {
            string name = c[0].ToString();
            int rating = Convert.ToInt32(c[1]);
            _db.createReview(name,rating);
            return View();
        } 
        //

        
        //
        // GET: /Reviews/Edit/5
    //[HttpGet]
    //    public ActionResult Edit()
    //    {
    //        return View();
    //    }

    //    //
    //    // POST: /Reviews/Edit/5

    //    [HttpPost]
    //    public ActionResult Edit(FormCollection collection)
    //    {
    //        try
    //        {
                
    //            // TODO: Add update logic here
    //            _db.editReview(Convert.ToInt32(collection[0]), collection[1], Convert.ToInt32(collection[2]));
    //            return RedirectToAction("Index");
    //        }
    //        catch
    //        {
    //            return View();
    //        }
    //    }

        //
        // GET: /Reviews/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reviews/Delete/5

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
