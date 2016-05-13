using System.Collections.Generic;
using PlanesTour.Core.Domain;
namespace PlanesTour.Repository.Contracts
{
    public interface IOfferRepository : IBaseRepository<Offer>
    {

        Offer GetOfferById(int offerId); 
        IEnumerable<Offer> GetAllOffers();
        
    }
}
