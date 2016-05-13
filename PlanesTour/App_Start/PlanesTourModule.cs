﻿using Ninject.Modules;
using Ninject.Web.Common;
using PlanesTour.Data;
using PlanesTour.AppServices;
using PlanesTour.Repository;
using PlanesTour.AppServices.Contracts;
using PlanesTour.Repository.Contracts;

// ReSharper disable once CheckNamespace
namespace PlanesTour.App_Start
{
    public class PlanesTourModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<PlanesTourDbContext>().ToSelf().InRequestScope();

            Kernel.Bind<IHotelRepository>().To<HotelRepository>();
            Kernel.Bind<ILocationRepository>().To<LocationRepository>();
            Kernel.Bind<IOfferRepository>().To<OfferRepository>();

            Kernel.Bind<IHotelService>().To<HotelService>();
            Kernel.Bind<IOfferService>().To<OfferService>();
            Kernel.Bind<ILocationService>().To<LocationService>();

            //throw new NotImplementedException();
        }
    }
}