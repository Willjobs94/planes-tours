using PlanesTour.AppServices.Contracts;
using PlanesTour.Core.Domain;
using PlanesTour.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanesTour.AppServices
{
    public  class OfferService : IOfferService
    {
        public OfferService(IOfferRepository offerRepository)
        {
            _offerRepository = offerRepository;
        }
        public IEnumerable<Offer> GetActiveOffers()
            => _offerRepository.GetAllOffers()
                .Where(a => a.ExpirationDate > DateTime.Now)
                .ToList();

        public IEnumerable<Offer> GetActiveOffers(int amount) 
            => GetActiveOffers()
                .Take(amount)
                .ToList();

        public Offer GetOfferById(int offerId)
            => _offerRepository.GetOfferById(offerId);

        public IEnumerable<Offer> GetAllOffers()
            => _offerRepository.GetAllOffers().ToList();

        public IEnumerable<Offer> GetAllOffers(int amount)
            => GetAllOffers().Take(amount).ToList();

        private readonly IOfferRepository _offerRepository;
    }
}
