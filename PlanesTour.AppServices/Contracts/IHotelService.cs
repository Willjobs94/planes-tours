using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.AppServices.Contracts
{
    public interface IHotelService
    {
        Hotel GetHotelById(int id);
        Hotel GetHotelByIdWithPhotos(int id);
        IEnumerable<Hotel> GetAllHotelsWithPhotos(int amount);
        IEnumerable<Hotel> GetAllHotelsByLocationIdWithPhotos(int locationId);
    }
}
