using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Auto.Core.Enums;
using Auto.Core.Models;

namespace Auto.Web.Core
{
    public static class Helper
    {
        public static User CurrentUser
        {
            get
            {
                return new User()
                {
                    Id = 23,
                    Name = "Standard Guy",
                    Password = "sunshine",
                    Username = "std",
                    UserType = UserType.Standard
                };
            }
        }
    }
}