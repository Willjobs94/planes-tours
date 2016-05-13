using System.Collections.Generic;
using PlanesTour.Core.Domain;
namespace PlanesTour.Repository.Contracts
{
    public interface IOffertRepository : IBaseRepository<Offer>
    {

        Offer GetOfferById(int offerId); 
        IEnumerable<Offer> GetAllOffers();
        
    }
}
