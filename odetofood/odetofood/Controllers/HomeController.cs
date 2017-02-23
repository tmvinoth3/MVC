using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odetofood.Models;
using System.Threading;

namespace odetofood.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewData["Message"] = string.Format("{0}::{1} {2}",
                RouteData.Values["controller"],
                RouteData.Values["action"],
                RouteData.Values["id"]);
            var model = new RestaurantReview()
            {
                Name = "salem-RR",
                Rating = 4
            };

            return View(model);
        }
        public string ServerTime()
        {
            Thread.Sleep(2000);
            return DateTime.Now.ToLongTimeString();
        }

        public ActionResult About()
        {
            
            return View();
        }
    }
}
