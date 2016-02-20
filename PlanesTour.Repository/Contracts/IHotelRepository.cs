using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.Core.Domain;
namespace PlanesTour.Repository.Contracts
{
   public interface IHotelRepository : IBaseRepository<Hotel>
    {
        Hotel GetHotelById(int hotelId);
        List<Hotel> GetAllHotels();
        List<Hotel> GetHotelsByLocation();
        List<Hotel> GetHotelsByLocation(Location location);
        List<Hotel> GetHotelsByViewCountDescendent();
        //List<Hotel> GetRelatedHotelsByLocation(Location location);
    }
}
