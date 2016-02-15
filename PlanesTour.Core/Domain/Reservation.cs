using System;
using System.Collections.Generic;

namespace PlanesTour.Core.Domain
{
    public class Reservation : EntityBase
    {
        #region Properties
        /// <summary>
        /// Indecates since when the user wants to make the reservation 
        /// </summary>
        public DateTime CheckInDate { get; set; }

        /// <summary>
        /// Indicates until when the user want to make the reservation
        /// </summary>
        public DateTime CheckOutDate { get; set; }

        /// <summary>
        /// How many Rooms the user wants to save
        /// </summary>
        public int RoomsAmount { get; set; }

        /// <summary>
        /// Indicates how many people are included in the reservations
        /// </summary>
        public int PeopleAmount { get; set; }

        /// <summary>
        /// In case of children, the age of each one
        /// </summary>
        public  List<Child> Children { get; set; }
        #endregion
    }
}
