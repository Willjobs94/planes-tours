using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using PlanesTour.Core.Domain;
using PlanesTour.Repository.Contracts;
using PlanesTour.Data;
namespace PlanesTour.Repository
{
    public class HotelRepository : BaseRepository<Hotel>, IHotelRepository
    {
        public HotelRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public Hotel GetHotelById(int hotelId)
            => GetById(hotelId);

        public Hotel GetHotelByIdWithPhotos(int hotelId)
        {
            var hotel = GetById(hotelId);
            hotel.Location = Context.Locations
                .FirstOrDefault(a => a.Id == hotel.LocationId);
            hotel.Photos = Context.HotelPhotos
                .Where(a => a.HotelId == hotel.Id)
                .Select(b => b.Photo).ToList();
            return hotel;
        }

        public IEnumerable<Hotel> GetAllHotels()
            => GetAll().Include(a => a.Location)
                .OrderByDescending(a => a.Name);

        private IEnumerable<Hotel> GetAllHotels(int amount)
            => GetAll().Take(amount).Include(a => a.Location)
                .OrderByDescending(a => a.Name);

        public IEnumerable<Hotel> GetAllHotelsWithPhotos(int amount)
        {
            var hotelList = GetAllHotels(amount).ToList();
            hotelList.ForEach(a => a.Photos = Context.HotelPhotos
                .Where(b => b.HotelId == a.Id)
                .Select(c => c.Photo)
                .ToList());
            return hotelList;
        }

        private IEnumerable<Hotel> GetHotelsByLocationId(int locationId)
            => GetAllHotels()
                .Where(a => a.LocationId == locationId);

        public IEnumerable<Hotel> GetAllHotelsByLocationIdWithPhotos(int locationId)
        {
            var hotelList = GetHotelsByLocationId(locationId).ToList();
            hotelList.ForEach(a => a.Photos = Context.HotelPhotos
                .Where(b => b.HotelId == a.Id)
                .Select(c => c.Photo)
                .ToList());
            return hotelList;
        }
    }
}
