using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.AppServices.Contracts
{
    public interface IHotelService 
    {
        void CreateNewHotel(Hotel hotel);
        void UpdateViewCount(int hotelId);
        IEnumerable<Hotel> GetAllHotels();
        IEnumerable<Hotel> GetAllHotels(int amount);
        IEnumerable<Hotel> GetAllHotelsWithPhotos(int amount);
        IEnumerable<Hotel> GetAllHotelsByLocationDescendent(int locationId);
        
    }
}
