//-----------------------------------------------------------------------
// <copyright file="D:\Documents\Visual Studio 2017\source\doanmonhocweb4\doanmonhocweb\doanmonhocweb\App_Start\RouteConfig.cs" company="">
//     Author:Nguyễn Văn Hiệp_1624801040019_D16HT01
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;


namespace doanmonhocweb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(name: "Default", 
                url: "{controller}/{action}/{id}", 
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }, 
                namespaces: new String[] { "doanmonhocweb.Controllers" });
        }
    }
}
