using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace PlanesTour.ViewModels.Error
{
    public class Error
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl  { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
    }
}