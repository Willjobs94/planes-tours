using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.Core.Domain;

namespace PlanesTour.AppServices.Contracts
{
    public interface ILocationService
    {
        List<Location> GetAllLocationsDescendingByName();
    }
}
