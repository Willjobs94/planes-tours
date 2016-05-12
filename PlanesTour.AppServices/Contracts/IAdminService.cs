using PlanesTour.Core.Domain;
using System.Collections.Generic;

namespace PlanesTour.AppServices.Contracts
{
    public interface IAdminService
    {
        IEnumerable<Hotel> GetAllHotels();
        IEnumerable<Offer> GetAllOffers();
        IEnumerable<Location> GetAllLocations();
    }
}
