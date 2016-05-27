using System;
using System.ComponentModel;
using Ninject;
using PlanesTour.Repository.Contracts;


namespace PlanesTour.Repository
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly IKernel _container;

        public RepositoryFactory(IKernel container)
        {
            _container = container;
        }
        public IBaseRepository<T> BuildRepository<T>() where T : class
        {
            var candidate = _container.Get<IBaseRepository<T>>();
            if (candidate == null)
            {
                throw new NullReferenceException("The requested Repository Type was not registered with the container.");
            }
            return candidate;
        }
    }
}
