using PlanesTour.Core.Domain;
using PlanesTour.Data;
using PlanesTour.Repository.Contracts;

namespace PlanesTour.Repository
{
    public class EntityFrameworkUnitOfWork : IUnitOfWork
    {
        public EntityFrameworkUnitOfWork(IRepositoryFactory repositoryFactory, PlanesTourDbContext context)
        {
            _repositoryFactory = repositoryFactory;
            Context = context;
        }

        private readonly IRepositoryFactory _repositoryFactory;

        public PlanesTourDbContext Context { get; }

        public IHotelRepository HotelRepository
            => (IHotelRepository)BuildRepository<Hotel>();

        public ILocationRepository LocationRepository 
            => (ILocationRepository)BuildRepository<Location>();

        public IOfferRepository OfferRepository 
            => (IOfferRepository)BuildRepository<Offer>();

        private IBaseRepository<T> BuildRepository<T>() where T : class
        {
            return _repositoryFactory.BuildRepository<T>();
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}
