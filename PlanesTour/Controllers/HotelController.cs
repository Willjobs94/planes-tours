using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlanesTour.AppServices.Contracts;
using PlanesTour.Helpers;
using System.IO;
using System.Web.UI.WebControls;
using PlanesTour.AppServices;

namespace PlanesTour.Controllers
{
    public class HotelController : Controller
    {
        public HotelController(IHotelService hotelService, 
            ILocationService locationService, IPhotoManager photoManager)
        {
            _hotelService = hotelService;
            _locationService = locationService;
            _photoManager = photoManager;
        }

        // GET: Hotel/2-title-url
        public ActionResult Detail(string url)
        {
            var hotelId = UrlHelperExtetions.GetIdFromUrl(url);
            if (hotelId == 0)
            {
               return RedirectToAction("Index", "Home");
            }


            var hotelViewModel = new ViewModels.Hotel.Detail
            {
                Hotel = _hotelService.GetHotelByIdWithPhotos(hotelId),
                RelatedHotels = _hotelService.GetAllHotelsWithPhotos(5)
            };

            return View(hotelViewModel);
        }

        [HttpPost]
        public ActionResult Create( ViewModels.Hotel.New model)
        {
            if (!ModelState.IsValid) return RedirectToAction("index", "home");
            var savedHotelId = _hotelService.CreateHotelWithPhotos(model.ToEntity(), model.FileBasePhotos);
            return RedirectToAction(nameof(Detail), new {url = UrlHelperExtetions.SeoUrl(savedHotelId, model.Name)});
        }

        public ActionResult Create()
        {
            var locations = _locationService.GetAllLocations();
            return View(locations);
        }

        private readonly IHotelService _hotelService;
        private readonly ILocationService _locationService;
        private readonly IPhotoManager _photoManager;
    }
}