using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using EasyCom.Api.Provider;
using EasyCom.Api.Provider.Interfaces;
using EasyCom.Api.Repository.Interfaces;

using EasyCom.Repository;
using Microsoft.Practices.Unity;


namespace EasyCom.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

          
           // GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(new UnityContainer());
        }
    }
}
