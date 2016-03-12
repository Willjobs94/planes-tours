using System.Collections.Generic;
using PlanesTour.Repository.Contracts;
using PlanesTour.Core.Domain;
using PlanesTour.Data;
namespace PlanesTour.Repository
{
    public abstract class OfferRepository : BaseRepository<Offer>, IOffertRepository
    {
        protected OfferRepository(PlanesTourDbContext context) : base(context) { }

        public IEnumerable<Offer> GetAllOffers() 
            => GetAll();     
    }
}
