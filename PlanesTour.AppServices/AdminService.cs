using PlanesTour.AppServices.Contracts;
using System.Collections.Generic;
using PlanesTour.Core.Domain;
using PlanesTour.Repository.Contracts;

namespace PlanesTour.AppServices
{
    public class AdminService : IAdminService 
    {
        public AdminService( IUnitOfWork unitOfWork)
        {
            _hotelRepository = unitOfWork.HotelRepository;
            _locationRepository = unitOfWork.LocationRepository;
            _offertRepository = unitOfWork.OfferRepository;
        }
        public IEnumerable<Hotel> GetAllHotels() 
        {
           return _hotelRepository.GetAllHotels();
        }

        public IEnumerable<Offer> GetAllOfferts()
        {
            return _offertRepository.GetAllOffers();
        }

        public IEnumerable<Location> GetAllLocations()
        {
            return _locationRepository.GetAllLocations();
        }

        public IEnumerable<Offer> GetAllOffers()
        {
            return _offertRepository.GetAllOffers();
        } 
        private readonly IHotelRepository _hotelRepository;
        private readonly IOfferRepository _offertRepository;
        private readonly ILocationRepository _locationRepository;
    } 
}
