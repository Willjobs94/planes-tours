using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlanesTour.Core.Domain
{
    class Hotel : EntityBase
    {
        #region Properties
        /// <summary>
        /// The identifier of the location
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// Photos of the hotel
        /// </summary>
        public List<Photo> Photos { get; set; }

        /// <summary>
        /// Users feedBacks of the hotel
        /// </summary>
        public List<FeedBack> FeedBacks { get; set; }

        /// <summary>
        /// Short description of what the hotel can offer to the clients
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }
        #endregion

        #region Property References
        /// <summary>
        /// Photo Entity Asociated with the hotel
        /// </summary>
        public Photo Photo { get; set; }

        /// <summary>
        /// Location Entity asociated with the hotel
        /// </summary>
        public Location Location { get; set; }
        #endregion

    }
}
