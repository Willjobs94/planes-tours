using System.Collections.Generic;

namespace PlanesTour.ViewModels.Hotel
{
    public class Detail
    {
        public Core.Domain.Hotel Hotel { get; set; }

        public IEnumerable<Core.Domain.Hotel> RelatedHotels { get; set; }

    }
}