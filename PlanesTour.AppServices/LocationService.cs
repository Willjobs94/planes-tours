using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.AppServices.Contracts;
using PlanesTour.Repository.Contracts;
using PlanesTour.Core.Domain;

namespace PlanesTour.AppServices
{
    public class LocationService : ILocationService
    {
        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public IEnumerable<Location>GetAllLocationsDescendingByName()
        {
            return _locationRepository.GetLocationsDescendingByName();
        }

        public Location GetLocationById(int locationId)
        {
            return _locationRepository.GetLocationsDescendingByName()
                .Where(a => a.Id == locationId).FirstOrDefault();
        }
        private readonly ILocationRepository _locationRepository;
    }
}
