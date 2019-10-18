using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HtmlHelperApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
            //1.注册路由信息
            routes.MapRoute(
               name: "Test",
               url: "{controller}_yujie/{action}.html/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
             );
        }
    }
}