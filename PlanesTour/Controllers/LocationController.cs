using PlanesTour.AppServices.Contracts;
using System.Web.Mvc;

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
            int locationId = GetIdFromUrl(url);
            if (locationId == 0)
            {
                return RedirectToAction("index");
            }
            ViewBag.LocationName = _locationService.GetLocationById(locationId).Name;
            return View(_hotelService. (locationId));
        }

        private int GetIdFromUrl(string url)
        {
            int id = 0;
            if (string.IsNullOrEmpty(url) || string.IsNullOrWhiteSpace(url) || !int.TryParse(url, out id))
            {
                return 0;
            }
            return id;
        }
        private readonly ILocationService _locationService;
        private readonly IHotelService _hotelService;
    }
}