using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlanesTour.AppServices.Contracts;
using PlanesTour.ViewModels;

namespace PlanesTour.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IHotelService hotelService, IOffertService offertService)
        {
            _hotelService = hotelService;
        }

        public ActionResult Index()
        {
            var hotels = _hotelService.GetAllHotels().Take(4);
            var offerts = _offertService.GetActiveOfferts().Take(5);
            var homeViewModel = new HomeViewModel
            {
                Hotels = hotels,
                Offerts = offerts
            };
            return View(homeViewModel);
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
        private readonly IOffertService _offertService;
    }
}