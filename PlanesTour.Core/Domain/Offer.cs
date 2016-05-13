using System;
using System.ComponentModel.DataAnnotations;

namespace PlanesTour.Core.Domain
{
    public class Offer : EntityBase
    {
        #region Properties
        /// <summary>
        /// Title of the Offer
        /// </summary>
        [MaxLength(50)]
        public string Title { get; set; }
        /// <summary>
        /// Hotel in which the offer applies 
        /// </summary>
        public int HotelId { get; set; }

        /// <summary>
        /// A short description of the offert
        /// </summary>
        [MaxLength(200)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates when the offer start
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Indicates when the Offert Expire
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// How many cuppuns does this offer have
        /// </summary>
        public int OffertAmount { get; set; }

        /// <summary>
        /// The Image Path of the Offert
        /// </summary>
        [MaxLength(254)]
        public string ImagePath { get; set; }
        #endregion

        #region Navigation Properties

        /// <summary>
        /// Hotel Entity asociated with the offer
        /// </summary>
        public Hotel Hotel { get; set; }
        #endregion
    }
}
