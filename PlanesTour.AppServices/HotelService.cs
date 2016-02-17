using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<Hotel>GetAllHotels()
        {
           return _hotelRepository.GetAllHotels();
        }

        public void UpdateViewCount(int hotelId)
        {
            var hotel = _hotelRepository.GetHotelById(hotelId);

            if (hotel == null) return;
            hotel.ViewCount++;
            _hotelRepository.SaveChanges(); 
        }

        public List<Hotel> GetAllHotelsByLocationDescendent()
        {
            return _hotelRepository.GetHotelsByLocation();
        }
        private readonly IHotelRepository _hotelRepository;
    }
}
