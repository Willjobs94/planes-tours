using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesTour.Core.Domain
{
    [Table("LocationPhotos")]
    public class LocationPhoto : EntityBase
    {
        public int LocationId { get; set; }
        public int PhotoId { get; set; }
    }
}
