using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using odetofood.Models;

namespace odetofood
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
     
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            "Restaurant",
            "{controller}/{action}/{name}",
            new { controller = "Restaurant", action = "Index", name = UrlParameter.Optional }
             );

            routes.MapRoute(
            "Review",
            "reviews",
            new { controller = "Reviews", action = "Index" }
             );
            routes.MapRoute(
                "Cuisine",
                "cuisine/{name}",
                new { controller = "Cuisine", action = "Search",name=UrlParameter.Optional }
                );

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            Database.SetInitializer(new foodDbInitializer());

            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);
        }

        public class foodDbInitializer : DropCreateDatabaseIfModelChanges<FoodDBsql>
        {
            protected override void Seed(FoodDBsql context)
            {
                base.Seed(context);

                context.Reviews.Add(new Review
                    {id = 1,
                    name = "Ram",
                    rating = 5});

                context.Reviews.Add(new Review
                {
                    id = 2,
                    name = "Sam",
                    rating = 4
                });

                context.Reviews.Add(new Review
                {
                    id = 3,
                    name = "Raj",
                    rating = 3
                });
            }

        }
    }
}