using System.Collections.Generic;
using PlanesTour.AppServices.Contracts;
using PlanesTour.Repository.Contracts;
using PlanesTour.Core.Domain;

namespace PlanesTour.AppServices
{
    public class HotelService : IHotelService
    {

        public HotelService(IHotelRepository hotelRespository)
        {
            _hotelRepository = hotelRespository;
        }

        public void CreateNewHotel(Hotel hotel)
        {
            _hotelRepository.Add(hotel);
            _hotelRepository.SaveChanges();
        }

        public IEnumerable<Hotel> GetAllHotels()
            => _hotelRepository.GetAllHotels();

        public IEnumerable<Hotel> GetAllHotels(int amount)
            => _hotelRepository.GetAllHotels(amount);

        public IEnumerable<Hotel> GetAllHotelsWithPhotos(int amount)
            => _hotelRepository.GetAllHotelsWithPhotos(amount);

        public void UpdateViewCount(int hotelId)
        {
            var hotel = _hotelRepository.GetHotelById(hotelId);
            if (hotel == null) return;
            hotel.ViewCount++;
            _hotelRepository.SaveChanges(); 
        }

        public IEnumerable<Hotel> GetAllHotelsByLocationDescendent(int locationId)
            => _hotelRepository.GetHotelsByLocationId(locationId);

        private readonly IHotelRepository _hotelRepository;
    }
}
