using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.AppServices.Contracts
{
    public interface IOffertService
    {
        List<Offer> GetActiveOfferts();
        List<Offer> GetActiveOfferts(int amount);
    }
}
