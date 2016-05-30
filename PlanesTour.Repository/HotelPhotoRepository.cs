using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.Core.Domain;
using PlanesTour.Data;
using PlanesTour.Repository.Contracts;

namespace PlanesTour.Repository
{
    public class HotelPhotoRepository : BaseRepository<HotelPhoto>, IHotelPhotoRepository
    {
        public HotelPhotoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void Save(int hotelId, IEnumerable<int> photosIdList)
        {
            foreach (var photoId in photosIdList)
            {
                var hotelPhoto = new HotelPhoto()
                {
                    HotelId = hotelId,
                    PhotoId = photoId
                };
                Add(hotelPhoto);
            }
            SaveChanges();
        }
    }
}
