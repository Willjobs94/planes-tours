using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanesTour.ViewModels.Offer
{
    public class Detail
    {
        public Core.Domain.Offer Offer { get; set; }
        public IEnumerable<Core.Domain.Hotel> RelatedHotels { get; set; }
    }
}