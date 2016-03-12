using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using PlanesTour.Core.Domain;
using PlanesTour.Repository.Contracts;
using PlanesTour.Data;
namespace PlanesTour.Repository
{
    public abstract class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        protected LocationRepository(PlanesTourDbContext context) : base(context) { }

        public IEnumerable<Location> GetAllLocations() => GetAll();

        public IEnumerable<Location> GetAllLocationsWithPhotos()
        {
            var locationList = GetAllLocations().ToList();
            locationList.ForEach(a =>
            {
                Debug.Assert(Context.LocationPhotos != null, "Context.LocationPhotos != null");
                a.Photos = Context.LocationPhotos
                    .Where(b => b.LocationId == a.Id)
                    .Select(c => c.Photo);
            });
            return locationList;
        }
    }
}
