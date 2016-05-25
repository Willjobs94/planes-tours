using System.Collections.Generic;
using System.Web;

namespace PlanesTour.AppServices.Contracts
{
    public interface IPhotoManager
    {
        /// <summary>
        /// Save Photo from httpPostedFilePase to file System
        /// </summary>
        /// <param name="fileBasePhoto"></param>
        /// <param name="photoType"></param>
        /// <param name="folderName"></param>
        /// <returns>string indicating the path the photo is saved</returns>
        string Save(HttpPostedFileBase fileBasePhoto, PhotoType photoType, string folderName);

        /// <summary>
        /// Save an amount of fileBase Photos
        /// </summary>
        /// <param name="fileBasePhotos"></param>
        /// <param name="photoType"></param>
        /// <param name="folderName"></param>
        /// <returns>An IEnumerable of string containing the path of all saved photos</returns>
        IEnumerable<string> Save(IEnumerable<HttpPostedFileBase> fileBasePhotos, PhotoType photoType, string folderName);

    }
}
