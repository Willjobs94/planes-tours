using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlanesTour.AppServices.Contracts;
using PlanesTour.Helpers;

namespace PlanesTour.Controllers
{
    public class OfferController : Controller
    {
        public OfferController(IOfferService offerService, IHotelService hotelService)
        {
            _offerService = offerService;
            _hotelService = hotelService;
        }
        // GET: Offer
        public ActionResult Detail(string url)
        {
            var offerId = UrlHelperExtetions.GetIdFromUrl(url);
            if (offerId == 0)
            {
                return RedirectToAction("Index", "Home");
            }

            var viewModel = new ViewModels.Offer.Detail
            {
                Offer = _offerService.GetOfferById(offerId),
                RelatedHotels = _hotelService.GetAllHotelsWithPhotos(5)
            };
            return View(viewModel);
        }

        private readonly IOfferService _offerService;
        private readonly IHotelService _hotelService;
    }
}