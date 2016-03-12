using System.Collections.Generic;
using System.Linq;
using PlanesTour.Data;
using PlanesTour.Core.Domain;
using PlanesTour.Repository.Contracts;

namespace PlanesTour.Repository
{
    public class FeedbackRepository : BaseRepository<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(PlanesTourDbContext context): base(context) { }

        public List<Feedback> GetFeedbacksByScoreDescending()
        {
            return DbSet.OrderByDescending(a => a.Score).ToList();
        }

        public List<Feedback> GetFeedbacksByHotelId(int hotelId)
        {
            return DbSet.Where(a => a.HotelId == hotelId).ToList();
        }

    }
}
