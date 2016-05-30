using System.Collections.Generic;
using PlanesTour.Repository.Contracts;
using PlanesTour.Core.Domain;
using PlanesTour.Data;
namespace PlanesTour.Repository
{
    public class OfferRepository : BaseRepository<Offer>, IOfferRepository
    {
        public OfferRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public Offer GetOfferById(int offerId) 
            => GetById(offerId);

        public IEnumerable<Offer> GetAllOffers()
            => GetAll();
    }
}
