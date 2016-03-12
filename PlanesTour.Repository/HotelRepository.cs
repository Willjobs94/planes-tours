using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using PlanesTour.Core.Domain;
using PlanesTour.Repository.Contracts;
using PlanesTour.Data;
namespace PlanesTour.Repository
{
    public abstract class HotelRepository : BaseRepository<Hotel>, IHotelRepository
    {
        protected HotelRepository(PlanesTourDbContext context) : base(context) { }

        public IEnumerable<Hotel> GetAllHotels() 
            => GetAll().Include(a => a.Location).OrderByDescending(a => a.Name);

        public IEnumerable<Hotel> GetAllHotels(int amount)
            => GetAll().Take(amount).Include(a => a.Location)
                .OrderByDescending(a => a.Name); 

        public IEnumerable<Hotel> GetHotelsByLocationId(int locationId)
            => GetAllHotels()
                .Where(a => a.LocationId == locationId).ToList();

        public IEnumerable<Hotel> GetAllHotelsWithPhotos(int amount)
        {
            var hotelList = GetAllHotels(amount).ToList();
            hotelList.ForEach(a => a.Photos = Context.HotelPhotos
                .Where(b => b.HotelId == a.Id)
                .Select(c => c.Photo)
                .ToList());          
            return hotelList;
        }

        public Hotel GetHotelById(int hotelId) 
            => GetById(hotelId);
    }
}
