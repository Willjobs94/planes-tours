using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using PlanesTour.Core.Domain;

namespace PlanesTour.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PlanesTourDbContext>
    {
        private readonly string _hotelsPhotoPath = ConfigurationManager.AppSettings.Get("HotelPhotoPath");
        private readonly string _imageRootPath = ConfigurationManager.AppSettings.Get("ImagesRootPath");

        private readonly string _locationPhotosPath = ConfigurationManager.AppSettings.Get("LocationPhotoPath");

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PlanesTourDbContext context)
        {
            //#region Offer List

            //var offerList = new List<Offer>
            //{
            //    new Offer
            //    {
            //        Title = "Ahorra hasta un 50% de Descuento",
            //        Description = "This is the best offer you can see",
            //        HotelId = 1,
            //        StartDate = DateTime.Now.AddDays(2),
            //        ExpirationDate = DateTime.Now.AddDays(7),
            //        OfferAmount = 100,
            //        ImagePath = Path.Combine(_imageRootPath, "")
            //    },
            //    new Offer
            //    {
            //        Title = "The best offer",
            //        Description = "This is the second best offer that you will see",
            //        HotelId = 2,
            //        StartDate = DateTime.Now.AddDays(2),
            //        ExpirationDate = DateTime.Now.AddDays(7),
            //        OfferAmount = 100,
            //        ImagePath = Path.Combine(_imageRootPath, "placeholdit400x300.png")
            //    },
            //    new Offer
            //    {
            //        Title = "Another good offer",
            //        Description = "Another offer",
            //        HotelId = 3,
            //        StartDate = DateTime.Now.AddDays(2),
            //        ExpirationDate = DateTime.Now.AddDays(7),
            //        OfferAmount = 100,
            //        ImagePath = Path.Combine(_imageRootPath, "placeholdit400x300.png")
            //    },
            //    new Offer
            //    {
            //        Title = "Hey this is an offer",
            //        Description = "Another offer 2",
            //        HotelId = 4,
            //        StartDate = DateTime.Now.AddDays(2),
            //        ExpirationDate = DateTime.Now.AddDays(7),
            //        OfferAmount = 100,
            //        ImagePath = Path.Combine(_imageRootPath, "placeholdit400x300.png")
            //    },
            //    new Offer
            //    {
            //        Title = "Aproveche la oferta",
            //        Description = "Another differten offer offer",
            //        HotelId = 5,
            //        StartDate = DateTime.Now.AddDays(2),
            //        ExpirationDate = DateTime.Now.AddDays(7),
            //        OfferAmount = 100,
            //        ImagePath = Path.Combine(_imageRootPath, "placeholdit400x300.png")
            //    }
            //};

            //foreach (var offer in offerList)
            //{
            //    context.Offers.AddOrUpdate(a => a.Title, offer);
            //}

            //#endregion

            //#region Photo List

            //var photoList = new List<Photo>
            //{
            //    #region Locations
            //    new Photo
            //    {
            //        Path = Path.Combine(_locationPhotosPath, "boca-chica", "01.jpg").Replace('\\', '/'),
            //        Description = "Boca Chica's Beach"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_locationPhotosPath, "juan-dolio", "01.jpg").Replace('\\', '/'),
            //        Description = "Juan Dolio's Beach"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_locationPhotosPath, "bayahibe", "01.jpg").Replace('\\', '/'),
            //        Description = "Bayahibe"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_locationPhotosPath, "punta-cana", "01.png").Replace('\\', '/'),
            //        Description = "Punta Cana"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_locationPhotosPath, "puerto-plata", "01.jpg").Replace('\\', '/'),
            //        Description = "Puerto Plata"
            //    },

            //    #endregion

            //    #region Boca Chica
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "don-juan-boca-chica", "01.jpg").Replace('\\', '/'),
            //        Description = "Don Juan Boca Chica"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "dominican-bay-boca-chica", "01.jpg").Replace('\\', '/'),
            //        Description = "Dominican Bay Boca Chica"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "hamaca-beach", "01.jpg").Replace('\\', '/'),
            //        Description = "Hamaca Beach"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "hamaca-garden", "01.jpg").Replace('\\', '/'),
            //        Description = "Hamaca Garden"
            //    },

            //    #endregion

            //    #region Bayahibe
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "be-live-canoa", "01.jpg").Replace('\\', '/'),
            //        Description = "Be live Canoa"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "catalonia-dominicus", "01.jpg").Replace('\\', '/'),
            //        Description = "Catalonia Dominicus"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "dreams-la-romana", "01.jpg").Replace('\\', '/'),
            //        Description = "Dreams La Romana"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "iberoestar-hacienda", "01.jpg").Replace('\\', '/'),
            //        Description = "Iberoestar Hacienda"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "viva-whyndham-dominicus-beach", "01.jpg").Replace('\\', '/'),
            //        Description = "Viva Whyndham Dominicus Beach"
            //    },

            //    #endregion

            //    #region Juan Dolio

            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "emotions", "01.jpg").Replace('\\', '/'),
            //        Description = "Emotions"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "hodelpa-garden-suite", "01.jpg").Replace('\\', '/'),
            //        Description = "Hodelpa Garden Suite"
            //    },

            //    #endregion

            //    #region Puerto Plata
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "be-live-marien", "01.jpg").Replace('\\', '/'),
            //        Description = "Be Live Marien"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "bluebays-villas-doradas", "01.jpg").Replace('\\', '/'),
            //        Description = "Blue Bays Villas Doradas"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "iberoestar-costa-dorada", "01.jpg").Replace('\\', '/'),
            //        Description = "Iberoestar Costa Dorada"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "lifestyle-tropical-beach", "01.jpg").Replace('\\', '/'),
            //        Description = "Life Style Tropical Beach"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "sunscape", "01.jpg").Replace('\\', '/'),
            //        Description = "Sunscape"
            //    },

            //    #endregion

            //    #region Punta Cana
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "hard-rock", "01.jpg").Replace('\\', '/'),
            //        Description = "Hard Rock"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "hotel-barcelo-deluxe-paradise", "01.jpg").Replace('\\', '/'),
            //        Description = "Hotel Barcelo Deluxe Paradise"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "hotel-barcelo-palace-deluxe", "01.jpg").Replace('\\', '/'),
            //        Description = "Hotel Barcelo Palace Deluxe"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "excellence", "01.jpg").Replace('\\', '/'),
            //        Description = "Hotel Excellence"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "nickelodeon", "01.jpg").Replace('\\', '/'),
            //        Description = "Nickelodeon"
            //    },
            //    new Photo
            //    {
            //        Path = Path.Combine(_hotelsPhotoPath, "paradisus-palma-real", "01.jpg").Replace('\\', '/'),
            //        Description = "Paradisus Palma Real"
            //    }

            //    #endregion
            //};
            //foreach (var photo in photoList)
            //{
            //    context.Photos.AddOrUpdate(a => a.Path, photo);
            //}

            //#endregion

            //#region Location List

            //var locationList = new List<Location>
            //{
            //    new Location
            //    {
            //        Name = "Boca Chica"
            //    },
            //    new Location
            //    {
            //        Name = "Juan Dolio"
            //    },
            //    new Location
            //    {
            //        Name = "Bayahibe"
            //    },
            //    new Location
            //    {
            //        Name = "Punta Cana"
            //    },
            //    new Location
            //    {
            //        Name = "Puerto Plata"
            //    }
            //};
            //foreach (var location in locationList)
            //{
            //    context.Locations.AddOrUpdate(a => a.Name, location);
            //}

            //#endregion

            //#region LocationPhoto List

            //foreach (var locationPhoto in context.Locations
            //    .Select(location => new LocationPhoto
            //{
            //    LocationId = location.Id,
            //    PhotoId = location.Id
            //}))
            //{
            //    context.LocationPhotos.AddOrUpdate(a => a.LocationId, locationPhoto);
            //}

            //#endregion

            //#region Hotel List

            //var hotelLIst = new List<Hotel>
            //{
            //    #region Boca Chica

            //    new Hotel
            //    {
            //        Name = "Hotel Dominican Bay",
            //        LocationId = 1
            //    },
            //    new Hotel
            //    {
            //        Name = "Hotel Don Juan",
            //        LocationId = 1
            //    },
            //    new Hotel
            //    {
            //        Name = "Be Live Hamaca Beach",
            //        LocationId = 1
            //    },
            //    new Hotel
            //    {
            //        Name = "Be Live Hamaca Garden",
            //        LocationId = 1
            //    },

            //    #endregion

            //    #region Bayahibe
            //    new Hotel
            //    {
            //        Name = "Be Live Canoa",
            //        LocationId = 3
            //    },
            //    new Hotel
            //    {
            //        Name = "Catalonia Dominicus",
            //        LocationId = 3
            //    },
            //    new Hotel
            //    {
            //        Name = "Dreams la Romana",
            //        LocationId = 3
            //    },
            //    new Hotel
            //    {
            //        Name = "Iberoestar Hacienda",
            //        LocationId = 3
            //    },
            //    new Hotel
            //    {
            //        Name = "Viva Wyndham Dominican Beach",
            //        LocationId = 3
            //    },

            //    #endregion

            //    #region Juan Dolio
            //    new Hotel
            //    {
            //        Name = "Emotions",
            //        LocationId = 2
            //    },
            //    new Hotel
            //    {
            //        Name = "Hodelpal Garden Suite",
            //        LocationId = 2
            //    },

            //    #endregion

            //    #region Puerto Plata
            //    new Hotel
            //    {
            //        Name = "Be Live Marien",
            //        LocationId = 5
            //    },
            //    new Hotel
            //    {
            //        Name = "Bluebays Villas Doradas",
            //        LocationId = 5
            //    },
            //    new Hotel
            //    {
            //        Name = "Iberostar Costa Dorada",
            //        LocationId = 5
            //    },
            //    new Hotel
            //    {
            //        Name = "Lifestyle Tropical Beach",
            //        LocationId = 5
            //    },
            //    new Hotel
            //    {
            //        Name = "Sunscape",
            //        LocationId = 5
            //    },

            //    #endregion

            //    #region Punta Cana
            //    new Hotel
            //    {
            //        Name = "Hard Rock",
            //        LocationId = 4
            //    },
            //    new Hotel
            //    {
            //        Name = "Barcelo Deluxe Paradise",
            //        LocationId = 4
            //    },
            //    new Hotel
            //    {
            //        Name = "Barcelo Palace Deluxe",
            //        LocationId = 4
            //    },
            //    new Hotel
            //    {
            //        Name = "Excellence",
            //        LocationId = 4
            //    },
            //    new Hotel
            //    {
            //        Name = "Nickelodeon",
            //        LocationId = 4
            //    },
            //    new Hotel
            //    {
            //        Name = "Paradisus Palma Real",
            //        LocationId = 4
            //    }
            //    #endregion
            //};
            //hotelLIst.ForEach(hotel => context.Hotels.AddOrUpdate(a => a.Name, hotel));

            //#endregion

            //#region HotelPhotoList

            //var photoid = 6;
            //foreach (var hotelPhoto in context.Hotels.Select(hotel => new HotelPhoto
            //{
            //    HotelId = hotel.Id,
            //    PhotoId = photoid
            //}))
            //{
            //    context.HotelPhotos.AddOrUpdate(a => a.HotelId, hotelPhoto);
            //    photoid++;
            //}

            //#endregion
        }
    }
}