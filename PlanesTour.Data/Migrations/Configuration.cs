namespace PlanesTour.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.IO;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PlanesTour.Core.Domain;
    using System.Collections.Generic;
    using System.Configuration;

    internal sealed class Configuration : DbMigrationsConfiguration<PlanesTour.Data.PlanesTourDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        private readonly string photoRootPath = ConfigurationManager.AppSettings.Get("PhotosRootPath");
        private readonly string imageRootPath = ConfigurationManager.AppSettings.Get("ImagesRootPath");
        protected override void Seed(PlanesTour.Data.PlanesTourDbContext context)
        {

          
            #region Photo List
            var photoList = new List<Photo>
            {
                new Photo
                {
                    Path = Path.Combine(photoRootPath, "bocachica.jpg"),
                    Description =  "Boca Chica's Beach"
                },

                new Photo
                {
                    Path = Path.Combine(photoRootPath, "juandolio.jpg"),
                    Description = "Juan Dolio's Beach"
                },

                new Photo
                {
                    Path = Path.Combine(photoRootPath, "bayahibe.png"),
                    Description = "Bayahibe"
                },

                new Photo
                {
                    Path = Path.Combine(photoRootPath, "puntacana.jpg"),
                    Description = "Punta Cana"
                },

                new Photo
                {
                    Path = Path.Combine(photoRootPath, "puertoplata.jpg"),
                    Description = "Puerto Plata"
                }

            };
            #endregion
            foreach (var photo in photoList)
            {
                context.Photos.AddOrUpdate(a => a.Path, photo);
            }

            #region Location List
            var locationList = new List<Location>
            {
                new Location
                {
                    Name = "Boca Chica",          
                },

                new Location
                {
                    Name = "Juan Dolio"
                },

                new Location
                {
                    Name = "Bayahibe"
                },
                
                new Location
                {
                    Name = "Punta Cana"
                },

                new Location
                {
                    Name = "Puerto Plata"
                }

            };
            #endregion
            foreach (var location in locationList)
            {
                context.Locations.AddOrUpdate(a => a.Name, location);
            }
            #region LocationPhoto List
            var locationPhotoList = new List<LocationPhoto>
            {
                new LocationPhoto
                {
                    LocationId = 1,
                    PhotoId = 1
                },

                new LocationPhoto
                {
                    LocationId = 2,
                    PhotoId = 2
                },

                new LocationPhoto
                {
                    LocationId = 3,
                    PhotoId = 3
                },
                
                new LocationPhoto
                {
                    LocationId = 4,
                    PhotoId = 4
                } ,

                new LocationPhoto
                {
                    LocationId = 5,
                    PhotoId = 5
                }
            };
            #endregion
            foreach (var locationPhoto in locationPhotoList)
            {
                context.LocationPhotos.AddOrUpdate(a => a.LocationId, locationPhoto);
            }
            #region Hotel List
            var hotelLIst = new List<Hotel>
            {
                new Hotel
                {
                    Name = "Be Live Hamaca Garden",
                    LocationId = 1
                },

                new Hotel
                {
                    Name = "Be Live Hamaca Beach",
                    LocationId = 1
                },

                new Hotel
                {
                    Name = "Be Live Hamaca suites",
                    LocationId = 1
                },

                new Hotel
                {
                     Name = "Hotel Don Juan",
                     LocationId = 1
                },

                new Hotel
                {
                    Name = "Hotel Dominican Bay",
                    LocationId = 1
                },

                new Hotel
                {
                    Name = "Hotel Coral Costa Caribe",
                    LocationId = 2
                },

                new Hotel
                {
                    Name = "Emotions by Hodelma",
                    LocationId = 2
                },

                new Hotel
                {
                    Name = "Dreams la Romana",
                    LocationId = 3
                },

                new Hotel
                {
                    Name = "Iberoestar Hacienda",
                    LocationId = 3
                },

                new Hotel
                {
                    Name = "Catalonia",
                    LocationId = 3
                },

                new Hotel
                {
                    Name = "Hotel Be Live Canoa",
                    LocationId = 3
                },

                new Hotel
                {
                    Name = "Viva Wyndham Dominican Beach",
                    LocationId = 3
                },

                new Hotel
                {
                    Name = "Barcelo Bavaro Beach",
                    LocationId = 4
                },

                new Hotel
                {
                    Name = "Hotel Hard Rock",
                    LocationId = 4
                },

                new Hotel
                {
                    Name = "Hotel Now Larimar",
                    LocationId = 4
                },

                new Hotel
                {
                    Name = "Hotel Paradisus Punta Cana",
                    LocationId = 4
                },

                new Hotel
                {
                    Name = "Hotel Bavaro Princess",
                    LocationId = 4
                },

                new Hotel
                {
                    Name = "iberostar Costa Dorada",
                    LocationId = 5
                },

                new Hotel
                {
                    Name = "Bluebays Villas Doradas",
                    LocationId = 5
                },

                new Hotel
                {
                    Name = "Riu Merengue",
                    LocationId = 5
                },

                new Hotel
                {
                    Name = "Riu Bachata",
                    LocationId = 5
                },

                new Hotel
                {
                    Name = "Lifestyle Tropical Beach",
                    LocationId = 5
                }
            };
            #endregion

            foreach (var hotel in hotelLIst)
            {
                context.Hotels.AddOrUpdate(a => a.Name, hotel);
            }

            #region Offert List
            var offertList = new List<Offert>
            {

                new Offert
                {
                    Description = " This is the best offert you can see",
                    HotelId = 1,
                    StartDate = DateTime.Now.AddDays(2),
                    ExpirationDate = DateTime.Now.AddDays(7),
                    OffertAmount = 100,
                    ImagePath = Path.Combine(imageRootPath, "placeholdit400x300")
                },

                new Offert
                {
                    Description = "This is the second best offert that you will see",
                    HotelId = 2,
                    StartDate = DateTime.Now.AddDays(2),
                    ExpirationDate = DateTime.Now.AddDays(7),
                    OffertAmount = 100,
                    ImagePath = Path.Combine(imageRootPath, "placeholdit400x300")

                },

                new Offert
                {
                    Description = "Another Offert",
                    HotelId = 3,
                    StartDate = DateTime.Now.AddDays(2),
                    ExpirationDate = DateTime.Now.AddDays(7),
                    OffertAmount = 100,
                    ImagePath = Path.Combine(imageRootPath, "placeholdit400x300")
                },

                new Offert
                {
                    Description = "Another Offert",
                    HotelId = 4,
                    StartDate = DateTime.Now.AddDays(2),
                    ExpirationDate = DateTime.Now.AddDays(7),
                    OffertAmount = 100,
                    ImagePath = Path.Combine(imageRootPath, "placeholdit400x300")
                },

                new Offert
                {
                    Description = "Another differten Offert Offert",
                    HotelId = 5,
                    StartDate = DateTime.Now.AddDays(2),
                    ExpirationDate = DateTime.Now.AddDays(7),
                    OffertAmount = 100,
                    ImagePath = Path.Combine(imageRootPath, "placeholdit400x300")
                }
            };
            #endregion

            foreach (var offert in offertList)
            {
                context.Offerts.AddOrUpdate(a => a.Description, offert);
            }
        }
    }
}
