using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.Core.Domain;
using PlanesTour.Repository.Contracts;
using PlanesTour.Data;

namespace PlanesTour.Repository.Contracts
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetUserByEmail(string userEmail);
    }
}
