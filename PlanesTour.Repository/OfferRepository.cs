using System.Collections.Generic;
using PlanesTour.Repository.Contracts;
using PlanesTour.Core.Domain;
using PlanesTour.Data;
namespace PlanesTour.Repository
{
    public class OfferRepository : BaseRepository<Offer>, IOffertRepository
    {
        public OfferRepository(PlanesTourDbContext context) : base(context) { }

        public Offer GetOfferById(int offerId) 
            => GetById(offerId);

        public IEnumerable<Offer> GetAllOffers()
            => GetAll();
    }
}
