using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.ViewModels.Home
{
    public class Index
    {
        public IEnumerable<Offer> Offerts { get; set; }
        public IEnumerable<Core.Domain.Hotel> Hotels { get; set; }
    }
}