using System.Collections.Generic;
using System.Web;
using PlanesTour.Core.Domain;


namespace PlanesTour.AppServices.Contracts
{
    public interface IHotelService
    {
        /// <summary>
        /// Create Hotel with extracted photos from httpPostedFileBase
        /// </summary>
        /// <param name="hotel"></param>
        /// <param name="fileBasePhotos"></param>
        /// <returns>hotel id saved in the database</returns>
        int CreateHotelWithPhotos(Hotel hotel, IEnumerable<HttpPostedFileBase> fileBasePhotos);
        Hotel GetHotelById(int id);
        Hotel GetHotelByIdWithPhotos(int id);
        IEnumerable<Hotel> GetAllHotelsWithPhotos(int amount);
        IEnumerable<Hotel> GetAllHotelsByLocationIdWithPhotos(int locationId);
    }
}
