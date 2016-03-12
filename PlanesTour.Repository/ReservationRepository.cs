using System.Collections.Generic;
using System.Linq;
using PlanesTour.Core.Domain;
using PlanesTour.Repository.Contracts;
using PlanesTour.Data;

namespace PlanesTour.Repository
{
    public class ReservationRepository : BaseRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(PlanesTourDbContext context) : base(context) { }
        
        public List<Reservation>GetReservationsByHotelId(int hotelId)
        {
            return DbSet.Where(a => a.HotelId == hotelId).ToList();
        }
        
        public List<Reservation> GetReservationsByCheckinDateDescending()
        {
            return DbSet.OrderByDescending(a => a.CheckInDate).ToList();
        }


    }

}
