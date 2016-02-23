using PlanesTour.AppServices.Contracts;
using PlanesTour.Core.Domain;
using PlanesTour.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesTour.AppServices
{
    public class OffertService : IOffertService
    {
        public OffertService(IOffertRepository offertRepository)
        {
            _offertRepository = offertRepository;
        }
        public List<Offert>GetActiveOfferts()
        {
            
            return _offertRepository.GetAllOfferts().Where(a => a.ExpirationDate > DateTime.Now).ToList();
        }
        public List<Offert>GetActiveOfferts(int amount)
        {
           return GetActiveOfferts().Take(amount).ToList();
        }

        private readonly IOffertRepository _offertRepository;
    }
}
