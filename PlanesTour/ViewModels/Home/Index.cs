using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.ViewModels.Home
{
    public class Index
    {
        public IEnumerable<Core.Domain.Offer> Offers { get; set; }
        public IEnumerable<Core.Domain.Hotel> Hotels { get; set; }
    }
}