using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Auto.Web.Core;

namespace Auto.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            if (CurrentUser == null) return new RedirectResult("/login");
            return View();
        }

    }
}
