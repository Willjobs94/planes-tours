﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.Core.Domain;

namespace PlanesTour.Repository.Contracts
{
    public interface IReservationRepository : IBaseRepository<Reservation>
    {
        List<Reservation> GetReservationsByHotelId(int hotelId);
        List<Reservation> GetReservationsByCheckinDateDescending();
    }
}
