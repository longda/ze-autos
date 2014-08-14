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
            return View();
        }

        public ActionResult MakeDropDown(int? selected)
        {
            ViewBag.Selected = selected;
            var makes = modelService.GetMakes().ToList();
            return PartialView("_MakeDropDown", makes);
        }
    }
}
