using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.AppServices.Contracts
{
    public interface IOffertService
    {
        IEnumerable<Offer> GetActiveOfferts(int amount);
    }
}
