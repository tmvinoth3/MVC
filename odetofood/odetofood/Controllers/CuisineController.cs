using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odetofood.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/
        [HttpGet]
        public ActionResult Search(string name = "*")
        {
            if (name == "*")
            {
                //throw new Exception("Oops!");
                //return Json(new { jsonName = name},JsonRequestBehavior.AllowGet);
               // return RedirectToRoute("Cuisine", new { name = "german"});
                //return RedirectToAction("Search", "cuisine", new { name = "french"});
            }

            name = Server.HtmlEncode(name);
            return Content("You have reached the cuisine controller "+name);
        }

    }
}
