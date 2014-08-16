using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Auto.Core.Enums;
using Auto.Core.Models;

namespace Auto.Web.Core
{
    public class BaseController : Controller
    {
        //  Again, not the best way to do this... might try to use action filters.
        public User CurrentUser
        {
            get
            {
                return Helper.CurrentUser;
            }
            set
            {
                Helper.CurrentUser = value;
            }
        }
    }
}