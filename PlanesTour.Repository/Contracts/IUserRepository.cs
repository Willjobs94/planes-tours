using PlanesTour.Core.Domain;

namespace PlanesTour.Repository.Contracts
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetUserByEmail(string userEmail);
    }
}
