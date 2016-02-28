using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlanesTour.Core.Domain
{
    public class Location : EntityBase
    {
        /// <summary>
        /// The location name 
        /// </summary>
        [MaxLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Photos related with this location
        /// </summary>
        public List<LocationPhoto> Photos { get; set; }
    }
}
