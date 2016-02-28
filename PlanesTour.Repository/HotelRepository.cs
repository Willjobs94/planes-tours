﻿using System;
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
        
        public List<Hotel>GetHotelsByLocation()
        {
            return GetAllHotels().OrderByDescending(a => a.Location.Name).ToList();
        }

        public List<Hotel> GetHotelsByLocation(Location location)
        {
            return DbSet.Where(a => a.LocationId == location.Id).ToList();
        }

        public List<Hotel> GetAllHotels()
        {
            var hotelList = Context.Hotels.ToList();
            hotelList.ForEach(a => a.Photos = Context.HotelPhotos
                .Where(b => b.HotelId == a.Id).Select(c => c.Photo).ToList());
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
