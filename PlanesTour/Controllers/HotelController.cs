using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlanesTour.AppServices.Contracts;
using PlanesTour.Helpers;

namespace PlanesTour.Controllers
{
    public class HotelController : Controller
    {
        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
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

        private readonly IHotelService _hotelService;
    }
}