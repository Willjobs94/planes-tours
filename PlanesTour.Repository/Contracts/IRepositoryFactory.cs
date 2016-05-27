using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesTour.Repository.Contracts
{
    public interface IRepositoryFactory
    {
        IBaseRepository<T> BuildRepository<T>() where T : class;
    }
}
