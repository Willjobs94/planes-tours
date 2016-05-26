using PlanesTour.Data;
using PlanesTour.Repository.Contracts;

namespace PlanesTour.Repository
{
    public class EntityFrameworkUnitOfWork : IUnitOfWork
    {
        public EntityFrameworkUnitOfWork(PlanesTourDbContext context)
        {
            Context = context;
        }

        public PlanesTourDbContext Context { get; }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public IHotelRepository HotelRepository 
            => _hotelRepository ?? new HotelRepository(this);

        public ILocationRepository LocationRepository 
            => _locationRepository ?? new LocationRepository(this);

        public IOfferRepository OfferRepository
            => _offerRepository ?? new OfferRepository(this);

        private readonly IHotelRepository _hotelRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly IOfferRepository _offerRepository;
    }
}
