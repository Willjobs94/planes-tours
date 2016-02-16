using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.Core.Domain;

namespace PlanesTour.Repository.Contracts
{
   public interface ILocationRepository : IBaseRepository<Location>
    {
        List<Location> GetLocationsByNameDescendent();
    }
}
