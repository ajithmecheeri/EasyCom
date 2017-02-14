using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using EasyCom.Api.Provider;
using EasyCom.Api.Provider.Interfaces;
using EasyCom.Api.Repository.Interfaces;
using EasyCom.Repository;
using Microsoft.Owin.Security.OAuth;
using Microsoft.Practices.Unity;
using Newtonsoft.Json.Serialization;

namespace EasyCom.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            var container = new UnityContainer();
           // container.RegisterType<ProductProvider>();
            container.RegisterType<IProductProvider, ProductProvider>();
           // IProductProvider providerObject = container.Resolve<ProductProvider>();
            config.DependencyResolver = new UnityResolver(container);

            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
               name: "WithActionApi1",
               routeTemplate: "api/{controller}/{action}/{productId}",
               defaults: new { productId = RouteParameter.Optional }
           );

            config.Routes.MapHttpRoute(
               name: "WithActionApi",
               routeTemplate: "api/{controller}/{action}/{id}",
               defaults: new { id = RouteParameter.Optional }
           );
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
