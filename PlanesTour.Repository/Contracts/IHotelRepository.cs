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
        List<Hotel> GetAllHotels(int amount);
        IEnumerable<Hotel> GetHotelsByLocation();
        IEnumerable<Hotel> GetHotelsByLocation(int locationId);
        List<Hotel> GetHotelsByViewCountDescendent();
    }
}
