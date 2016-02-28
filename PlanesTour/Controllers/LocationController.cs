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
        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }
        public ActionResult Index()
        {
            var locations = _locationService.GetAllLocationsDescendingByName();
            return View(locations);
        }

        private readonly ILocationService _locationService;
    }
}