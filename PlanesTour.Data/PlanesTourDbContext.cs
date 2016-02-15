using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.Core.Domain;

namespace PlanesTour.Data
{
    public class PlanesTourDbContext : DbContext
    {
        public PlanesTourDbContext()     
            : base ("LocalConnection")
        {

        }

        public DbSet<User> Users { get; set; }

    }
}
