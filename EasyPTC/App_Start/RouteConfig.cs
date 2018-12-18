using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EasyPTC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //Routes to ignore.The [*] means all left
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                //Route name
                name: "StaticPages",
                //Root pattern
                url: "{action}",
                //Default parameters
                defaults: new { controller = "Home" }
                );

            routes.MapRoute(
                name: "Default",
                //Controller: Products; Action: ById; Id: 3
                url: "{controller}/{action}/{id}",
                // Id: o(oprional parameter)
                defaults: new { controller = "Home",
                                action = "Index",
                                id = UrlParameter.Optional }
            );
        }
    }
}
