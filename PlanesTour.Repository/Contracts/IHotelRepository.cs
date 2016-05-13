using System.Collections.Generic;
using PlanesTour.Core.Domain;
namespace PlanesTour.Repository.Contracts
{
   public interface IHotelRepository : IBaseRepository<Hotel>
    {
        Hotel GetHotelById(int hotelId);
        Hotel GetHotelByIdWithPhotos(int hotelId);
        IEnumerable<Hotel> GetAllHotels();
        IEnumerable<Hotel> GetAllHotelsWithPhotos(int amount);
        IEnumerable<Hotel> GetAllHotelsByLocationIdWithPhotos(int locationId);
    }
}
