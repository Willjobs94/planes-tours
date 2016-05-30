using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlanesTour.ViewModels.Hotel
{
    public class New
    {
        [Required (ErrorMessage = "El nombre del Hotel es requerido")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required (ErrorMessage = "Seleccione un destino para el hotel")]
        public int LocationId { get; set; }

        [Required (ErrorMessage = "Debe Seleccionar al menos una foto")]
        public HttpPostedFileBase[] FileBasePhotos { get; set; }

        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        public Core.Domain.Hotel ToEntity()
        {
            return new Core.Domain.Hotel()
            {
                Name = Name,
                LocationId = LocationId,
                Description = Description
            };
        }
    }


}