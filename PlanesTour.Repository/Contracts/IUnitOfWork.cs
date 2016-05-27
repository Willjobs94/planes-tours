using PlanesTour.Core.Domain;
using PlanesTour.Data;

namespace PlanesTour.Repository.Contracts
{
    public interface IUnitOfWork
    {

        PlanesTourDbContext Context { get; }
        IHotelRepository HotelRepository { get; }
        ILocationRepository LocationRepository { get; }
        IOfferRepository OfferRepository { get; }
        void Commit();

    }
}
