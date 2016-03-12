using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.Repository.Contracts
{
   public interface ILocationRepository : IBaseRepository<Location>
    {
        IEnumerable<Location> GetAllLocations();
        IEnumerable<Location> GetAllLocationsWithPhotos();
    }
}
