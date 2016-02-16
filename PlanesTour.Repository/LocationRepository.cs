using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.Core.Domain;
using PlanesTour.Repository.Contracts;
using PlanesTour.Data;
namespace PlanesTour.Repository
{
    public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        public LocationRepository(PlanesTourDbContext context) : base(context) { }

        public List<Location>GetLocationsByNameDescendent()
        {
            return DbSet.OrderByDescending(a => a.Name).ToList();
        }
    }
}
