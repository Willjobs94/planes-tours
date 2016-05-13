using PlanesTour.AppServices.Contracts;
using System.Web.Mvc;

namespace PlanesTour.Controllers
{
    public class AdminController : Controller
    {
        public AdminController( ILocationService locationService, IHotelService hotelService, IOffertService offertService)
        {
            _hotelService = hotelService;
            _locationService = locationService;
            _offertService = offertService;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        private readonly ILocationService _locationService;
        private readonly IHotelService _hotelService;
        private readonly IOffertService _offertService;

    }
}