﻿using System.Collections.Generic;
using PlanesTour.AppServices.Contracts;
using PlanesTour.Repository.Contracts;
using PlanesTour.Core.Domain;

namespace PlanesTour.AppServices
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class HotelService : IHotelService
    {
        public HotelService(IHotelRepository hotelRespository)
        {
            _hotelRepository = hotelRespository;
        }

        public IEnumerable<Hotel> GetAllHotelsWithPhotos(int amount)
            => _hotelRepository.GetAllHotelsWithPhotos(amount);

        public IEnumerable<Hotel> GetAllHotelsByLocationIdWithPhotos(int locationId)
            => _hotelRepository.GetAllHotelsByLocationIdWithPhotos(locationId);

        private readonly IHotelRepository _hotelRepository;
    }
}
