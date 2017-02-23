using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odetofood.Models;

namespace odetofood.Controllers
{
    public class RestaurantController : Controller
    {
        //
        // GET: /Restaurant/
        FoodDBsql _db = new FoodDBsql();

        public ActionResult Index(string name)
        {
            //var model = from r in _db.Reviews
            //            select r;


            var model = _db.Reviews.
                          Where(r => r.name == name || r.name == null).
                          Select(r => r);
            return View(model);
        }

    }
}
