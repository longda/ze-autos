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
    public class ReportController : BaseController
    {
        private readonly IReportService reportService;

        public ReportController(IReportService reportService)
        {
            this.reportService = reportService;
        }

        public ActionResult Index()
        {
            if (CurrentUser == null || !CurrentUser.IsAdmin) return new RedirectResult("/");
            var m = reportService.GetMileageReport();

            return View(m);
        }
    }
}
