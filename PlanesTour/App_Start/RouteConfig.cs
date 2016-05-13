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
                name: "offer",
                url: "offers/{url}",
                defaults: new {controller = "Offer", action = "Detail"},
                constraints: new {url = @"\d+[a-z-A-Z-]+"}
            );

            routes.MapRoute(
                name: "hotel",
                url: "hotels/{url}",
                defaults: new {controller = "Hotel", action = "Detail"},
                constraints: new {url = @"\d+[a-z-A-Z-]+" }
            );

            routes.MapRoute(
                name: "Defautl hotel route",
                url: "hotels/{action}",
                defaults: new {controller = "hotel", action = "index"}
            );

            routes.MapRoute(
                name: "location", 
                url: "locations/{url}",
                defaults: new { controller = "Location", action = "Detail" },
                constraints: new { url = @"\d+[a-z-A-Z-]+" }
            );

            routes.MapRoute(
                name: "Default location route",
                url: "locations/{action}",
                defaults: new { controller = "Location", action = "index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
