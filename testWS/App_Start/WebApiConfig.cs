using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace testWS
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "verify user",
                routeTemplate: "api/{controller}/{action}/{username}/{password}",
                defaults: new {  username = RouteParameter.Optional, password = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
