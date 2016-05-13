using PlanesTour.AppServices.Contracts;
using PlanesTour.Core.Domain;
using PlanesTour.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanesTour.AppServices
{
    public  class OffertService : IOffertService
    {
        public OffertService(IOffertRepository offertRepository)
        {
            _offertRepository = offertRepository;
        }
        public IEnumerable<Offer> GetActiveOfferts()
            => _offertRepository.GetAllOffers()
                .Where(a => a.ExpirationDate > DateTime.Now)
                .ToList();

        public IEnumerable<Offer> GetActiveOfferts(int amount) 
            => GetActiveOfferts()
                .Take(amount)
                .ToList();

        public Offer GetOfferById(int offerId)
            => _offertRepository.GetOfferById(offerId);

        public IEnumerable<Offer> GetAllOffers()
            => _offertRepository.GetAllOffers().ToList();

        public IEnumerable<Offer> GetAllOffers(int amount)
            => GetAllOffers().Take(amount).ToList();
        private readonly IOffertRepository _offertRepository;
    }
}
