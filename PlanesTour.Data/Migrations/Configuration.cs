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

        private readonly string locationPhotosPath = ConfigurationManager.AppSettings.Get("LocationPhotoPath");
        private readonly string hotelsPhotoPath = ConfigurationManager.AppSettings.Get("HotelPhotoPath");
        private readonly string imageRootPath = ConfigurationManager.AppSettings.Get("ImagesRootPath");
        protected override void Seed(PlanesTourDbContext context)
        {

            #region Offert List
            var offertList = new List<Offert>
            {

                new Offert
                {
                    Description = "This is the best offert you can see",
                    HotelId = 1,
                    StartDate = DateTime.Now.AddDays(2),
                    ExpirationDate = DateTime.Now.AddDays(7),
                    OffertAmount = 100,
                    ImagePath = Path.Combine(imageRootPath, "")
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
                    Description = "Another Offert 2",
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

            foreach (var offert in offertList)
            {
                context.Offerts.AddOrUpdate(a => a.Description, offert);
            }
            #endregion

            #region Photo List
            var photoList = new List<Photo>
            {

                #region Locations
                new Photo
                {
                    Path = Path.Combine(locationPhotosPath, "boca-chica", "01.jpg").Replace('\\', '/'),
                    Description =  "Boca Chica's Beach"
                },

                new Photo
                {
                    Path = Path.Combine(locationPhotosPath, "juan-dolio", "01.jpg").Replace('\\', '/'),
                    Description = "Juan Dolio's Beach"
                },

                new Photo
                {
                    Path = Path.Combine(locationPhotosPath, "bayahibe", "01.jpg").Replace('\\', '/'),
                    Description = "Bayahibe"
                },

                new Photo
                {
                    Path = Path.Combine(locationPhotosPath, "punta-cana", "01.png").Replace('\\', '/'),
                    Description = "Punta Cana"
                },

                new Photo
                {
                    Path = Path.Combine(locationPhotosPath, "puerto-plata", "01.jpg").Replace('\\', '/'),
                    Description = "Puerto Plata"
                },

                #endregion

                #region Boca Chica
                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "don-juan-boca-chica", "01.jpg").Replace('\\','/'),
                    Description = "Don Juan Boca Chica"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "dominican-bay-boca-chica", "01.jpg").Replace('\\','/'),
                    Description = "Dominican Bay Boca Chica"
                },


                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "hamaca-beach", "01.jpg").Replace('\\','/'),
                    Description = "Hamaca Beach"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "hamaca-garden", "01.jpg").Replace('\\','/'),
                    Description = "Hamaca Garden"
                },

                #endregion

                #region Bayahibe
                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "be-live-canoa", "01.jpg").Replace('\\','/'),
                    Description = "Be live Canoa"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "catalonia-dominicus", "01.jpg").Replace('\\','/'),
                    Description = "Catalonia Dominicus"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "dreams-la-romana", "01.jpg").Replace('\\','/'),
                    Description = "Dreams La Romana"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "iberoestar-hacienda", "01.jpg").Replace('\\','/'),
                    Description = "Iberoestar Hacienda"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "viva-whyndham-dominicus-beach", "01.jpg").Replace('\\','/'),
                    Description = "Viva Whyndham Dominicus Beach"
                },

                #endregion

                #region Juan Dolio

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "emotions", "01.jpg").Replace('\\','/'),
                    Description = "Emotions"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "hodelpa-garden-suite", "01.jpg").Replace('\\','/'),
                    Description = "Hodelpa Garden Suite"
                },
                #endregion

                #region Puerto Plata
                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "be-live-marien", "01.jpg").Replace('\\','/'),
                    Description = "Be Live Marien"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "bluebays-villas-doradas", "01.jpg").Replace('\\','/'),
                    Description = "Blue Bays Villas Doradas"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "iberoestar-costa-dorada", "01.jpg").Replace('\\','/'), 
                    Description = "Iberoestar Costa Dorada"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "lifestyle-tropical-beach", "01.jpg").Replace('\\','/'),
                    Description = "Life Style Tropical Beach"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "sunscape", "01.jpg").Replace('\\','/'),
                    Description = "Sunscape"
                },
                #endregion

                #region Punta Cana
                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "hard-rock", "01.jpg").Replace('\\','/'),
                    Description = "Hard Rock"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "hotel-barcelo-deluxe-paradise", "01.jpg").Replace('\\','/'),
                    Description = "Hotel Barcelo Deluxe Paradise"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "hotel-barcelo-palace-deluxe", "01.jpg").Replace('\\','/'),
                    Description = "Hotel Barcelo Palace Deluxe"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "excellence", "01.jpg").Replace('\\','/'),
                    Description = "Hotel Excellence"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "nickelodeon", "01.jpg").Replace('\\','/'),
                    Description = "Nickelodeon"
                },

                new Photo
                {
                    Path = Path.Combine(hotelsPhotoPath, "paradisus-palma-real", "01.jpg").Replace('\\','/'),
                    Description = "Paradisus Palma Real"
                }

                #endregion

            };
            foreach (var photo in photoList)
            {
                context.Photos.AddOrUpdate(a => a.Path, photo);
            }
            #endregion

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
            foreach (var location in locationList)
            {
                context.Locations.AddOrUpdate(a => a.Name, location);
            }
            #endregion

            #region LocationPhoto List
            foreach (var location in context.Locations)
            {
                var locationPhoto = new LocationPhoto
                {
                    LocationId = location.Id,
                    PhotoId = location.Id
                };
                context.LocationPhotos.AddOrUpdate(a => a.LocationId, locationPhoto);
            }
            #endregion

            #region Hotel List
            var hotelLIst = new List<Hotel>
            {
                #region Boca Chica

                new Hotel
                {
                    Name = "Hotel Dominican Bay",
                    LocationId = 1
                },

                new Hotel
                {
                        Name = "Hotel Don Juan",
                        LocationId = 1
                },


                new Hotel
                {
                    Name = "Be Live Hamaca Beach",
                    LocationId = 1
                },

                new Hotel
                {
                    Name = "Be Live Hamaca Garden",
                    LocationId = 1
                },
                #endregion

                #region Bayahibe
                new Hotel
                {
                    Name = "Be Live Canoa",
                    LocationId = 3
                },

                new Hotel
                {
                    Name = "Catalonia Dominicus",
                    LocationId = 3
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
                    Name = "Viva Wyndham Dominican Beach",
                    LocationId = 3
                },

                #endregion

                #region Juan Dolio
                new Hotel
                {
                    Name = "Emotions",
                    LocationId = 2
                },

                new Hotel
                {
                    Name = "Hodelpal Garden Suite",
                    LocationId = 2
                },
                #endregion

                #region Puerto Plata
                new Hotel
                {
                    Name = "Be Live Marien",
                    LocationId = 5
                },

                new Hotel
                {
                    Name = "Bluebays Villas Doradas",
                    LocationId = 5
                },

                new Hotel
                {
                    Name = "Iberostar Costa Dorada",
                    LocationId = 5
                },

                new Hotel
                {
                    Name = "Lifestyle Tropical Beach",
                    LocationId = 5
                },

                new Hotel
                {
                    Name = "Sunscape",
                    LocationId = 5
                },
                #endregion

                #region Punta Cana
                new Hotel
                {
                    Name = "Hard Rock",
                    LocationId = 4
                },

                new Hotel
                {
                    Name = "Barcelo Deluxe Paradise",
                    LocationId = 4
                },


                new Hotel
                {
                    Name = "Barcelo Palace Deluxe",
                    LocationId = 4
                },

                new Hotel
                {
                    Name = "Excellence",
                    LocationId = 4
                },

                new Hotel
                {
                    Name = "Nickelodeon",
                    LocationId = 4
                },

                new Hotel
                {
                    Name = "Paradisus Palma Real",
                    LocationId = 4
                },
                #endregion

            };
            hotelLIst.ForEach(hotel => context.Hotels.AddOrUpdate(a => a.Name, hotel));
            #endregion

            #region HotelPhotoList
            var photoid = 6;
            foreach (var hotel in context.Hotels)
            {
                var hotelPhoto = new HotelPhoto
                {
                    HotelId = hotel.Id,
                    PhotoId = photoid
                };
                context.HotelPhotos.AddOrUpdate(a => a.HotelId, hotelPhoto);
                photoid++;
            }
            #endregion
        }
    }
}
