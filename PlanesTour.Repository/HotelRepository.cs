using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
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
        
        public IEnumerable<Hotel>GetHotelsByLocation()
        {
            return GetAllHotels().OrderByDescending(a => a.Location.Name).ToList();
        }

        public IEnumerable<Hotel> GetHotelsByLocation(int locationId)
        {
            return GetHotelsByLocation().Where(a => a.LocationId == locationId).ToList();
        }

        public List<Hotel> GetAllHotels()
        {
            var hotelList = Context.Hotels.Include(a => a.Location).ToList();
            hotelList.ForEach(a => a.Photos = Context.HotelPhotos
                .Where(b => b.HotelId == a.Id)
                .Select(c => c.Photo)
                .ToList());          
            return hotelList;
        }
        public List<Hotel> GetAllHotels(int amount)
        {
            return GetAllHotels().Take(amount).ToList();
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
