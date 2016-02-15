using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesTour.Repository.Contracts
{
    public interface IBaseRepository<in T> where T : class
    {
        void SaveChanges();
        void Add(T entity);
    }
}
