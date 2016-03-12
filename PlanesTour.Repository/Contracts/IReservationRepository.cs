using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.Repository.Contracts
{
    public interface IReservationRepository : IBaseRepository<Reservation>
    {
        List<Reservation> GetReservationsByHotelId(int hotelId);
        List<Reservation> GetReservationsByCheckinDateDescending();
    }
}
