using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Dotnet_Practical_10
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Custom route for Employee/Name
            routes.MapRoute(
                name: "EmployeeRoute",
                url: "Employee/{name}",
                defaults: new { controller = "Employee", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employee", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
