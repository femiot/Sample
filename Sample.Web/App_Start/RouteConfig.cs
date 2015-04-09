using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sample.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection route)
        {
            route.Ignore("{resource}.axd/{*pathInfo}");

            route.MapRoute(
                name: "Default",
                url: "{Controller}/{Action}/{id}",
                defaults: new { Controller = "Home", Action = "Index", id = UrlParameter.Optional });
        }
    }
}