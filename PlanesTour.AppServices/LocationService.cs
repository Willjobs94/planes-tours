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

        public List<Location>GetAllLocationsDescendingByName()
        {
            return _locationRepository.GetLocationsDescendingByName();
        }
        private readonly ILocationRepository _locationRepository;
    }
}
