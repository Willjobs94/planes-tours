using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanesTour.Core.Domain;

namespace PlanesTour.Repository.Contracts
{
    public interface IPhotoRepository : IBaseRepository<Photo>
    {
        /// <summary>
        /// Create photo entity with respectives paths
        /// </summary>
        /// <param name="paths"></param>
        /// <returns>An IEnumerable of int contained the generated Id for each photo</returns>
        IEnumerable<int> Add(IEnumerable<string> paths);
    }
}
