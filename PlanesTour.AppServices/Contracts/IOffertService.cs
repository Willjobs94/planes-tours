using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.AppServices.Contracts
{
    public interface IOffertService
    {
        Offer GetOfferById(int offerId);
        IEnumerable<Offer> GetAllOffers();
        IEnumerable<Offer> GetAllOffers(int amount);
        IEnumerable<Offer> GetActiveOfferts(int amount);
    }
}
