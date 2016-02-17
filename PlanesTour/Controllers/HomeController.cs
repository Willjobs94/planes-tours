using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlanesTour.AppServices.Contracts;

namespace PlanesTour.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        public ActionResult Index()
        {
            var hotels = _hotelService.GetAllHotels();
            return View(hotels);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private readonly IHotelService _hotelService;
    }
}