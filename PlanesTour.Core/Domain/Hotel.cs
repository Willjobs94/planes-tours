using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlanesTour.Core.Domain
{
    public class Hotel : EntityBase
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
        public List<Feedback> FeedBacks { get; set; }

        /// <summary>
        /// Short description of what the hotel can offer to the clients
        /// </summary>
        [MaxLength(300)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates how many times this hotel link have been visited
        /// </summary>
        public int ViewCount { get; set; }
        #endregion

        #region Navigation Properties
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
