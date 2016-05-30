using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.Core.Domain;

namespace PlanesTour.Repository.Contracts
{
    public interface IHotelPhotoRepository : IBaseRepository<HotelPhoto>
    {
        /// <summary>
        /// Save the relation between an hotelId and a list of photoIds
        /// </summary>
        /// <param name="hotelId"></param>
        /// <param name="photosIdList"></param>
        void Save(int hotelId, IEnumerable<int> photosIdList);
    }
}
