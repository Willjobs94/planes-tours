using System.ComponentModel.DataAnnotations;

namespace PlanesTour.Core.Domain
{
    public class User : EntityBase
    {
        #region Properties
        /// <summary>
        /// The user Name
        /// </summary>
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// The user phone number that will be use for the agent to contact him
        /// </summary>
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The user Email that will be use use fot ehe agent to contact him
        /// </summary>
        [MaxLength(40)]
        public string Email { get; set; }
        #endregion
    }
}
