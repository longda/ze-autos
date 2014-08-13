using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Auto.Core.Models;
using Auto.Core.Services.Interfaces;
using Auto.Web.Core;

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
            var m = modelService.GetVehicles(Helper.CurrentUser.Id).ToList();
            return View(m);
        }

        [HttpPost]
        public ActionResult Save(Vehicle input)
        {
            input.UserId = Helper.CurrentUser.Id;
            return Json(modelService.SaveVehicle(input));
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var result = false;
            var v = modelService.GetVehicle(id);
            if (v != null && v.UserId == Helper.CurrentUser.Id)
            {
                result = modelService.DeleteVehicle(id);
            }

            return Json(new { success = result });
        }
    }
}
