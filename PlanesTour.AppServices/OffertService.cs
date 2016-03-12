using PlanesTour.AppServices.Contracts;
using PlanesTour.Core.Domain;
using PlanesTour.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanesTour.AppServices
{
    public class OffertService : IOffertService
    {
        public OffertService(IOffertRepository offertRepository)
        {
            _offertRepository = offertRepository;
        }
        public List<Offer>GetActiveOfferts()
        {
            
            return _offertRepository.GetAllOffers().Where(a => a.ExpirationDate > DateTime.Now).ToList();
        }
        public List<Offer>GetActiveOfferts(int amount)
        {
           return GetActiveOfferts().Take(amount).ToList();
        }

        private readonly IOffertRepository _offertRepository;
    }
}
