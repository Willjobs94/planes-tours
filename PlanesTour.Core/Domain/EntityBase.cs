using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesTour.Core
{
    /// <summary>
    /// Where inherit all system classes, avoid duplucation and helps to keep the models clean
    /// </summary>
    public class EntityBase
    {
        protected EntityBase ()
        {
            Created = DateTime.Now;
        }
        #region Properies
        /// <summary>
        /// Unique identifier of each entity
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// All entity should have a field which represent the date created for posibles references on
        /// section
        /// </summary>
        public DateTime Created { get; set; }
        #endregion
    }
}
