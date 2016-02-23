using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlanesTour.Core.Domain
{
    [Table("HotelPhotos")]
    public class HotelPhoto : EntityBase
    {
        public int HotelId { get; set; }
        public int PhotoId { get; set; }
    }
}
