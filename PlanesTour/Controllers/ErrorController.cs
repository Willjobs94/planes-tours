using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PlanesTour.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Http403()
        {
            var viewModel = new ViewModels.Error.Error
            {
                Title = "Permiso Denegado",
                Description = "Lo siento, no tienes permiso para hacer eso",
                HttpStatusCode = HttpStatusCode.Forbidden
            };
            return View("Index", viewModel);
        }

        public ActionResult Http404()
        {
            var viewModel = new ViewModels.Error.Error
            {
                Title = "Lo siento, no encontré lo que buscabas",
                Description = "Descuida, no eres la primera persona que le pasa esto",
                HttpStatusCode = HttpStatusCode.NotFound
            };
            return View("Index", viewModel);
        }

        public ActionResult Htt500()
        {
            var viewModel = new ViewModels.Error.Error
            {
                Title = "Ups, algo salió mal",
                Description = "Hemos sido notificados de este error, lo resolveremos tan pronto como sea posible",
                HttpStatusCode = HttpStatusCode.InternalServerError
            };

            return View("Index", viewModel);
        }
    }
}