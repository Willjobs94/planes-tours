using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesTour.Core.Domain
{
    class Photo : EntityBase
    {
        /// <summary>
        /// The path of the photo
        /// </summary>
        public string Path { get; set; }
    }
}
