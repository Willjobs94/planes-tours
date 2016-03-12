using System.Collections.Generic;
using PlanesTour.Core.Domain;
namespace PlanesTour.Repository.Contracts
{
    public interface IOffertRepository : IBaseRepository<Offer>
    {
        IEnumerable<Offer> GetAllOffers();
    }
}
