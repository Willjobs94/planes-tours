﻿using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.AppServices.Contracts
{
    public interface ILocationService
    {
        IEnumerable<Location> GetAllLocationsWithPhotos();
        Location GetLocationById(int? locationId);
    }
}
