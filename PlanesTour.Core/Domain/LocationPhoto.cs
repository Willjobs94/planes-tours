using System.ComponentModel.DataAnnotations.Schema;

namespace PlanesTour.Core.Domain
{
    [Table("LocationPhotos")]
    public class LocationPhoto : EntityBase
    {
        public int LocationId { get; set; }
        public int PhotoId { get; set; }

        public Location Location { get; set; }

        public Photo Photo { get; set; }
    }
}
