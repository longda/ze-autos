using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

using Auto.Core.Enums;
using Auto.Core.Models;
using Auto.Web.Core;

namespace Auto.Web.Core
{
    public static class Helper
    {
        public static User CurrentUser
        {
            get
            {
                var s = HttpContext.Current.Session["auto.current_user"] as string;
                if (string.IsNullOrEmpty(s)) return null;

                return Helper.DeserializeFromJson(s);
            }
            set
            {
                HttpContext.Current.Session["auto.current_user"] = value.ToJsonString();
            }
        }

        public static User DeserializeFromJson(string input)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Deserialize<User>(input);
        }
    }
}