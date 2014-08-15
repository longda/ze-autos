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
    public class MakeController : Controller
    {
        private readonly IModelService modelService;

        public MakeController(IModelService modelService)
        {
            this.modelService = modelService;
        }

        public ActionResult Index()
        {
            var m = modelService.GetMakes().ToList();
            return View(m);
        }

        [HttpPost]
        public ActionResult Save(Make input)
        {
            return Json(modelService.SaveMake(input));
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var result = false;
            var m = modelService.GetMake(id);
            if (m != null)
            {
                result = modelService.DeleteMake(id);
            }

            return Json(new { success = result });
        }

        public ActionResult MakeDropDown(int? selected)
        {
            ViewBag.Selected = selected;
            var makes = modelService.GetMakes().ToList();
            return PartialView("_MakeDropDown", makes);
        }
    }
}
