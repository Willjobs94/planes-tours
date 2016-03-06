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

            routes.MapRoute(
                name: "location detail",
                url : "locations/{id}",
                defaults : new {controller = "Location", action = "Detail"},
                constraints: new {id = @"\d+"}
            );

            routes.MapRoute(
                name: "Default for Location",
                url: "locations/{action}",
                defaults: new { controller = "Location" , action = "index"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
