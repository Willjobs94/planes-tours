using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.Repository.Contracts;
using PlanesTour.Core.Domain;

namespace PlanesTour.AppServices.Contracts
{
    public interface IHotelService
    {
        void CreateNewHotel(Hotel hotel);
        void UpdateViewCount(int hotelId);

        List<Hotel> GetAllHotels();
        List<Hotel> GetAllHotelsByLocationDescendent();
    }
}
