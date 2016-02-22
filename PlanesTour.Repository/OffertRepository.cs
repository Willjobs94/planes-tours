using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.Repository.Contracts;
using PlanesTour.Core.Domain;
using PlanesTour.Data;
namespace PlanesTour.Repository
{
    public class OffertRepository : BaseRepository<Offert>, IOffertRepository
    {
        public OffertRepository(PlanesTourDbContext context) : base(context) { }

        public List<Offert> GetAllOfferts()
        {
            return GetAll().ToList();
        }
    }
}
