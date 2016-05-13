using PlanesTour.AppServices.Contracts;
using System.Web.Mvc;

namespace PlanesTour.Controllers
{
    public class AdminController : Controller
    {
        public AdminController( ILocationService locationService, IHotelService hotelService, IOfferService offerService)
        {
            _hotelService = hotelService;
            _locationService = locationService;
            _offerService = offerService;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        private readonly ILocationService _locationService;
        private readonly IHotelService _hotelService;
        private readonly IOfferService _offerService;

    }
}