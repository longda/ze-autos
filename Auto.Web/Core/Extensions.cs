using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace Auto.Web.Core
{
    public static class Extensions
    {
        private static JavaScriptSerializer serializer = new JavaScriptSerializer();

        public static string ToJsonString(this object obj)
        {
            return serializer.Serialize(obj);
        }

        public static string ToJsonString(this object obj, int recursionDepth)
        {
            serializer.RecursionLimit = recursionDepth;
            return serializer.Serialize(obj);
        }
    }
}