using System.Web.Mvc;
using PlanesTour.AppServices.Contracts;
using PlanesTour.ViewModels.Home;

namespace PlanesTour.Controllers
{
    public class HomeController : Controller
    {   
        public HomeController(IHotelService hotelService, IOfferService offerService)
        {
            _hotelService = hotelService;
            _offerService = offerService;
        }

        public ActionResult Index()
        {
            var hotels = _hotelService.GetAllHotelsWithPhotos(8);
            var offers = _offerService.GetAllOffers(5);
            var indexViewModel = new Index
            {
                Hotels = hotels,
                Offers = offers
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
        private readonly IOfferService _offerService;
    }
}