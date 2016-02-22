namespace PlanesTour.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PlanesTour.Core.Domain;
    using System.Collections.Generic;
    internal sealed class Configuration : DbMigrationsConfiguration<PlanesTour.Data.PlanesTourDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PlanesTour.Data.PlanesTourDbContext context)
        {

            #region Location List
            var locationList = new List<Location>
            {
                new Location
                {
                    Name = "Boca Chica"
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
        }
    }
}
