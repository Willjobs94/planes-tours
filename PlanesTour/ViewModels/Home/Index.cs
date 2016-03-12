using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.ViewModels.Home
{
    public class Index
    {
        public IEnumerable<Offer> Offerts { get; set; }
        public IEnumerable<Hotel> Hotels { get; set; }
    }
}