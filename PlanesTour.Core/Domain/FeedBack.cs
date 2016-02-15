using System.ComponentModel.DataAnnotations;

namespace PlanesTour.Core.Domain
{
    public class FeedBack : EntityBase
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
        public string Description { get; set; }
        #endregion
    }
}
