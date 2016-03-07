using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PlanesTour
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.LowercaseUrls = true;

            routes.MapRoute(
                name: "location", 
                url: "locations/{url}",
                defaults: new { controller = "Location", action = "Detail" },
                constraints: new { url = @"\d+"}
            );

            routes.MapRoute(
                name: "locations",
                url: "locations/{action}",
                defaults: new { controller = "Location", action = "Detail" }
            );

            routes.MapRoute(
            name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
