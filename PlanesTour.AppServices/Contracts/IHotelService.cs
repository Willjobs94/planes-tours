using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.AppServices.Contracts
{
    public interface IHotelService 
    {
        IEnumerable<Hotel> GetAllHotelsWithPhotos(int amount);
        IEnumerable<Hotel> GetAllHotelsByLocationIdWithPhotos(int locationId);
    }
}
