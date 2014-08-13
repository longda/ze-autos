using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Auto.Core.Models;
using Auto.Core.Services.Interfaces;

namespace Auto.Web.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IModelService modelService;

        public VehicleController(IModelService modelService)
        {
            this.modelService = modelService;
        }

        public ActionResult Index()
        {
            var m = modelService.GetVehicles(1).ToList();
            return View(m);
        }

    }
}
