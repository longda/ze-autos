using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Auto.Core.Models;
using Auto.Core.Services.Interfaces;
using Auto.Web.Core;
using Auto.Web.Models;

namespace Auto.Web.Controllers
{
    public class VehicleController : BaseController
    {
        private readonly IModelService modelService;

        public VehicleController(IModelService modelService)
        {
            this.modelService = modelService;
        }

        public ActionResult Index()
        {
            if (CurrentUser == null) return new RedirectResult("~/");
            var vm = new VehicleViewModel();
            vm.Vehicles = modelService.GetVehicles(CurrentUser.Id).ToList();
            vm.Makes = modelService.GetMakes().ToList();
            
            return View(vm);
        }

        [HttpPost]
        public ActionResult Save(Vehicle input)
        {
            if (CurrentUser == null) return new RedirectResult("~/");

            if (input.Id != 0)
            {
                var v = modelService.GetVehicle(input.Id);
                if (v.UserId == CurrentUser.Id)
                {
                    modelService.SaveVehicle(input);
                }
            }
            else
            {
                input.UserId = CurrentUser.Id;
                modelService.SaveVehicle(input);
            }

            return Json(modelService.SaveVehicle(input));
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (CurrentUser == null) return new RedirectResult("~/");

            var result = false;
            var v = modelService.GetVehicle(id);
            if (v != null && v.UserId == CurrentUser.Id)
            {
                result = modelService.DeleteVehicle(id);
            }

            return Json(new { success = result });
        }
    }
}
