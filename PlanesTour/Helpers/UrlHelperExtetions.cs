using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace PlanesTour.Helpers
{
    public static class UrlHelperExtetions
    {
        public static int GetIdFromUrl(string seoUrl)
        {
            int id;
            var url = seoUrl.Split('-');

            if (string.IsNullOrEmpty(seoUrl) || url.Length == 0 || !int.TryParse(url[0], out id))
                return 0;

            return id;
        }

        /// <summary>
        /// returns "safe" URL, stripping anything outside normal charsets for URL
        /// </summary>
        /// <param name="strToSanitize"></param>
        /// <returns></returns>
        public static string SanitizeString(this string strToSanitize)
        {
            return strToSanitize == null
                ? null
                : Regex.Replace(strToSanitize, @"[^A-Za-z0-9_~&@#/%?=~_|!:,.;\(\)]+", "-");
        }

        /// <summary>
        /// Convert id and title into SEO url Id-Title
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static string SeoUrl(int id, string title)
        {
            return string.IsNullOrEmpty(title) ? id.ToString() : $"{id}-{SanitizeString(title)}";
        }

    }
}