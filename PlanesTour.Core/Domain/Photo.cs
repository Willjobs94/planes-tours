using System.ComponentModel.DataAnnotations;

namespace PlanesTour.Core.Domain
{
    public class Photo : EntityBase
    {
        /// <summary>
        /// The path of the photo
        /// </summary>
        [MaxLength(254)]
        public string Path { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
