﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesTour.Core.Domain
{
    class User : EntityBase
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
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The user Email that will be use use fot ehe agent to contact him
        /// </summary>
        [MaxLength(40)]
        public string Email { get; set; }
        #endregion
    }
}