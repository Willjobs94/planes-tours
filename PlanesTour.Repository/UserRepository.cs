using PlanesTour.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.Core.Domain;
using PlanesTour.Data;
namespace PlanesTour.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(PlanesTourDbContext context) : base(context) { }

        public User GetUserByEmail(string userEmail)
        {
            return DbSet.Where(a => a.Email == userEmail).Single();
        }
    }
}
