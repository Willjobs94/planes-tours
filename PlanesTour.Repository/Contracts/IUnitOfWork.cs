using PlanesTour.Data;

namespace PlanesTour.Repository.Contracts
{
    public interface IUnitOfWork
    {
        PlanesTourDbContext Context { get; }
        void SaveChanges();
        IHotelRepository HotelRepository  { get; }
        ILocationRepository LocationRepository { get; }
        IOfferRepository OfferRepository { get; }

    }
}
