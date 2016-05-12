using PlanesTour.AppServices.Contracts;
using System.Web.Mvc;
using PlanesTour.Helpers;

namespace PlanesTour.Controllers
{
    public class LocationController : Controller
    {
        public LocationController(ILocationService locationService, IHotelService hotelService)
        {
            _locationService = locationService;
            _hotelService = hotelService;
        }
        public ActionResult Index() 
            => View(_locationService.GetAllLocationsWithPhotos());


        public ActionResult Detail(string url)
        {
            var locationId = UrlHelperExtetions.GetIdFromUrl(url);
            if (locationId == 0)
            {
                return RedirectToAction("index");
            }
            ViewBag.LocationName = _locationService.GetLocationById(locationId).Name;
            return View(_hotelService.GetAllHotelsByLocationIdWithPhotos(locationId));
        }

        [ChildActionOnly]
        public ActionResult GetLocations()
        {
            var locationList = _locationService.GetAllLocations();
            return PartialView("_LocationListDropdownPartial", locationList);
        }

        private readonly ILocationService _locationService;
        private readonly IHotelService _hotelService;
    }
}