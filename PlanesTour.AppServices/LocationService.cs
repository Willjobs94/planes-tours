using System.Collections.Generic;
using System.Linq;
using PlanesTour.AppServices.Contracts;
using PlanesTour.Repository.Contracts;
using PlanesTour.Core.Domain;
using PlanesTour.Repository;

namespace PlanesTour.AppServices
{
    public class LocationService : ILocationService
    {
        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public IEnumerable<Location>GetAllLocations() 
            => _locationRepository.GetAllLocations();

        public IEnumerable<Location> GetAllLocationsWithPhotos() 
            => _locationRepository.GetAllLocationsWithPhotos();

        public Location GetLocationById(int? locationId)
            => _locationRepository.GetAllLocations()
                .FirstOrDefault(a => a.Id == locationId);

        private readonly ILocationRepository _locationRepository;
    }
}
