using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using PlanesTour.AppServices.Contracts;
using PlanesTour.Repository.Contracts;
using PlanesTour.Core.Domain;

namespace PlanesTour.AppServices
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class HotelService : IHotelService
    {
        public HotelService(IHotelRepository hotelRespository, 
            IPhotoRepository photoRepository,
            IPhotoManager photoManager, IHotelPhotoRepository hotelPhotoRepository, ILocationRepository locationRepository)
        {
            _hotelRepository = hotelRespository;
            _photoRepository = photoRepository;
            _photoManager = photoManager;
            _hotelPhotoRepository = hotelPhotoRepository;
            _locationRepository = locationRepository;
        }

        public int CreateHotelWithPhotos(Hotel hotel, IEnumerable<HttpPostedFileBase> fileBasePhotos)
        {
            var _hotel = hotel;
            _hotelRepository.Add(_hotel);
            _hotelRepository.SaveChanges();
            var photosPathList = _photoManager.Save(fileBasePhotos, PhotoType.Hotel, _hotel.Name);
            var photosIdList = _photoRepository.Add(photosPathList);
            _hotelPhotoRepository.Save(_hotel.Id, photosIdList);
            return _hotel.Id;
        }

        public Hotel GetHotelById(int id)
            => _hotelRepository.GetHotelById(id);

        public Hotel GetHotelByIdWithPhotos(int id)
            => _hotelRepository.GetHotelByIdWithPhotos(id);

        public IEnumerable<Hotel> GetAllHotelsWithPhotos(int amount)
            => _hotelRepository.GetAllHotelsWithPhotos(amount);

        public IEnumerable<Hotel> GetAllHotelsByLocationIdWithPhotos(int locationId)
            => _hotelRepository.GetAllHotelsByLocationIdWithPhotos(locationId);

        private readonly IHotelRepository _hotelRepository;
        private readonly IPhotoRepository _photoRepository;
        private readonly IPhotoManager _photoManager;
        private readonly IHotelPhotoRepository _hotelPhotoRepository;
        private readonly ILocationRepository _locationRepository;
    }
}
