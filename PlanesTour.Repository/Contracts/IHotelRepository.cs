using System.Collections.Generic;
using PlanesTour.Core.Domain;
namespace PlanesTour.Repository.Contracts
{
   public interface IHotelRepository : IBaseRepository<Hotel>
    {
        Hotel GetHotelById(int hotelId);
        IEnumerable<Hotel> GetAllHotels();
        IEnumerable<Hotel> GetAllHotels(int amount);
        IEnumerable<Hotel> GetAllHotelsWithPhotos(int amount);
        IEnumerable<Hotel> GetHotelsByLocationId(int locationId);
    }
}
