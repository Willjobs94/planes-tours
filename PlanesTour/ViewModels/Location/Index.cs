using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlanesTour.Core.Domain;
namespace PlanesTour.ViewModels.Location
{
    public class Index
    {
        public List<Core.Domain.Location> Locations { get; set; }
        public List<LocationPhoto> LocationsPhotos { get; set; }
    }
}