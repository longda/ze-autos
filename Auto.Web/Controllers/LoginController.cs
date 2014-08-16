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
    public class LoginController : BaseController
    {
        private readonly IAuthenticationService authService;

        public LoginController(IAuthenticationService authService)
        {
            this.authService = authService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            // Typically, you'd do some validation/error handling with the user here.
            CurrentUser = authService.Login(username, password);

            return Json(new { url = Url.Content("~/") });
        }
    }
}
