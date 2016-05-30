using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using PlanesTour.AppServices.Contracts;

namespace PlanesTour.AppServices
{
    public class PhotoManager : IPhotoManager
    {
        private readonly string _hotelsPhotoPath = ConfigurationManager.AppSettings.Get("HotelPhotoPath");
        private readonly string _locationPhotosPath = ConfigurationManager.AppSettings.Get("LocationPhotoPath");
        public string Save(HttpPostedFileBase fileBasePhoto, PhotoType photoType, string folderName)
        {
            var path = string.Empty;
            switch (photoType)
            {
                case PhotoType.Hotel:
                    path = _hotelsPhotoPath;
                    break;
                case PhotoType.Location:
                    path = _locationPhotosPath;
                    break;
             }
            var directory =  Path.Combine(path, SanitizeString(folderName)).Replace("\\", "/");
            var pathToFile = Path.Combine(directory, fileBasePhoto.FileName).Replace("\\", "/");

            Directory.CreateDirectory(HttpContext.Current.Server.MapPath(directory));
            fileBasePhoto.SaveAs(HttpContext.Current.Server.MapPath(pathToFile));

            return pathToFile;
        }

        public IEnumerable<string> Save(IEnumerable<HttpPostedFileBase> fileBasePhotos, PhotoType photoType, string folderName) 
            => fileBasePhotos.Select(fileBasePhoto 
                => Save(fileBasePhoto, photoType, folderName))
                .ToList();


        private static string SanitizeString(string strToSanitize) 
            => 
            strToSanitize == null
            ? null
            : Regex.Replace(strToSanitize, @"[^A-Za-z0-9]+", "-");
    }
}