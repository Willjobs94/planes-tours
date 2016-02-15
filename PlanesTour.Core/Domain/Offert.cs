using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesTour.Core.Domain
{
    public class Offert : EntityBase
    {
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
        /// Indicate is the offer is active
        /// </summary>
        public bool IsActive { get; set; }
    }
}
