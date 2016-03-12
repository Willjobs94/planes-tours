using System.ComponentModel.DataAnnotations.Schema;


namespace PlanesTour.Core.Domain
{
    [Table("HotelPhotos")]
    public class HotelPhoto : EntityBase
    {
        public int HotelId { get; set; }
        public int PhotoId { get; set; }
        public Hotel Hotel { get; set; }
        public Photo Photo { get; set; }
    }
}
