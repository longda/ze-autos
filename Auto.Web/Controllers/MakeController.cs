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
    public class MakeController : BaseController
    {
        private readonly IModelService modelService;

        public MakeController(IModelService modelService)
        {
            this.modelService = modelService;
        }

        public ActionResult Index()
        {
            if (CurrentUser == null || !CurrentUser.IsAdmin) return new RedirectResult("/");
            var m = modelService.GetMakes().ToList();
            return View(m);
        }

        [HttpPost]
        public ActionResult Save(Make input)
        {
            // Probably better to do this with some sort of action filter system.
            // Also would be beter to be more restful, return proper error codes, etc.
            if (CurrentUser == null || !CurrentUser.IsAdmin) return new RedirectResult("/");
            return Json(modelService.SaveMake(input));
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (CurrentUser == null || !CurrentUser.IsAdmin) return new RedirectResult("/");
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
