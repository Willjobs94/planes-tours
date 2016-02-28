using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlanesTour.AppServices.Contracts;
using PlanesTour.ViewModels.Home;

namespace PlanesTour.Controllers
{
    public class HomeController : Controller
    {

        
        public HomeController(IHotelService hotelService, IOffertService offertService)
        {
            _hotelService = hotelService;
            _offertService = offertService;
        }

        public ActionResult Index()
        {
            var hotels = _hotelService.GetAllHotels(3);
            var offerts = _offertService.GetActiveOfferts(3);
            var indexViewModel = new Index
            {
                Hotels = hotels,
                Offerts = offerts
            };
            return View(indexViewModel);
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