using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.Core.Domain;
using PlanesTour.Repository.Contracts;
using PlanesTour.Data;
namespace PlanesTour.Repository
{
    public class HotelRepository : BaseRepository<Hotel>, IHotelRepository
    {
        public HotelRepository(PlanesTourDbContext context) : base(context) { }
        
        public List<Hotel>GetHotelsByLocation()
        {
            return GetAll().OrderByDescending(a => a.Location.Name).ToList();
        }

        public List<Hotel> GetHotelsByLocation(Location location)
        {
            return DbSet.Where(a => a.LocationId == location.Id).ToList();
        }

        public List<Hotel> GetAllHotels()
        {
            return GetAll().ToList();
        }

        public List<Hotel> GetHotelsByViewCountDescendent()
        {
            return DbSet.OrderByDescending(a => a.ViewCount).ToList();
        }

        public Hotel GetHotelById(int hotelId)
        {
            return GetById(hotelId);
        }
        
    }
}
