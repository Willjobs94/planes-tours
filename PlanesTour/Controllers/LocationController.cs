using PlanesTour.AppServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        {
            return View(_locationService.GetAllLocationsDescendingByName());
        }

        public ActionResult Detail(string url)
        {
            int locationId = GetIdFromUrl(url);
            if (locationId == 0)
            {
                return RedirectToAction("index");
            }
            ViewBag.LocationName = _locationService.GetLocationById(locationId).Name;
            return View(_hotelService.GetAllHotelsByLocationDescendent(locationId));
        }

        private int GetIdFromUrl(string url)
        {
            int id = 0;
            if (string.IsNullOrEmpty(url) || string.IsNullOrWhiteSpace(url) || !Int32.TryParse(url, out id))
            {
                return 0;
            }
            return id;
        }
        private readonly ILocationService _locationService;
        private readonly IHotelService _hotelService;
    }
}