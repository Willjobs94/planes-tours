using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.AppServices.Contracts
{
    public interface ILocationService
    {
        Location GetLocationById(int? locationId);
        IEnumerable<Location> GetAllLocations();
        IEnumerable<Location> GetAllLocationsWithPhotos();
    }
}
