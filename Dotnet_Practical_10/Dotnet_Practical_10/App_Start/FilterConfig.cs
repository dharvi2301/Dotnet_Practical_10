﻿using System.Web;
using System.Web.Mvc;

namespace Dotnet_Practical_10
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
