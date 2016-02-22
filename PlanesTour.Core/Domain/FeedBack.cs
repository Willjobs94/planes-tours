using System.ComponentModel.DataAnnotations;

namespace PlanesTour.Core.Domain
{
    public class Feedback : EntityBase
    {
        #region Properties
        /// <summary>
        /// The score that a particular user gives to the hotel in a range from 0 to 5
        /// </summary>
        [Range(0, 5, ErrorMessage = "The score value must be between 0 or 5")]
        public int Score { get; set; }
        /// <summary>
        /// Short reason about why a particular user gives an hotel the that score
        /// </summary>
        [MaxLength(500)]
        public string Description { get; set; }
        /// <summary>
        /// The hotel that the feedback is asociated with
        /// </summary>
        public int HotelId { get; set; }
        /// <summary>
        /// Indicates is a feedback have been aproved for the admin to be shown
        /// </summary>
        public bool isAproved { get; set; }
        #endregion

        #region Navigation Properties
        public Hotel Hotel { get; set; }
        #endregion
    }
}
