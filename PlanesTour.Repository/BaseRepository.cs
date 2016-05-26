using PlanesTour.Data;
using PlanesTour.Repository.Contracts;
using System.Data.Entity;
using System.Linq;

namespace PlanesTour.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where  T : class
    {  
        protected readonly PlanesTourDbContext Context;
        protected readonly DbSet<T> DbSet;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            Context = unitOfWork.Context;
            DbSet = unitOfWork.Context.Set<T>();
        }

        protected T GetById(int? id)
        {
            return DbSet.Find(id);
        }

        protected IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

    }
}
