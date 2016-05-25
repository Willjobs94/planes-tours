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
    public class PhotoRepository : BaseRepository<Photo>, IPhotoRepository
    {
        public PhotoRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
        public IEnumerable<int> Add(IEnumerable<string> paths)
        {
            var savedPhotosId = new List<int>();
            foreach (var path in paths)
            {
                var photo = new Photo()
                {
                    Path = path
                };
                Add(photo);
                SaveChanges();
                savedPhotosId.Add(photo.Id);
            }
            return savedPhotosId;
        }
    }
}
