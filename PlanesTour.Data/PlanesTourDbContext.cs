using System.Data.Entity;
using PlanesTour.Core.Domain;

namespace PlanesTour.Data
{
    public class PlanesTourDbContext : DbContext
    {
        public PlanesTourDbContext()     
            : base ("LocalConnection")
        {

        }

        public DbSet<Feedback> FeedBacks { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Offert> Offerts { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Child> Children { get; set; }


    }
}
