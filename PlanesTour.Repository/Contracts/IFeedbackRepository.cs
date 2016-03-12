using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.Repository.Contracts
{
   public interface IFeedbackRepository : IBaseRepository<Feedback>
    {
        List<Feedback> GetFeedbacksByScoreDescending();

        List<Feedback> GetFeedbacksByHotelId(int hotelId);
    }
}
