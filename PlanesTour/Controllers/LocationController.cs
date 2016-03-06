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

        public ActionResult Detail(int locationId)
        {
            ViewBag.LocationName = _locationService.GetLocationById(locationId).Name;
            return View(_hotelService.GetAllHotelsByLocationDescendent(locationId));
        }

        private readonly ILocationService _locationService;
        private readonly IHotelService _hotelService;
    }
}