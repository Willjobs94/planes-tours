using System.Collections.Generic;
using PlanesTour.Core.Domain;

namespace PlanesTour.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Offert> Offerts { get; set; }
        public IEnumerable<Hotel> Hotels { get; set; }
    }
}