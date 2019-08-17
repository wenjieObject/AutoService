using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using BLL;

namespace WebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static IContainer AutofacContainer;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            #region Autofac注入依赖
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.Load("BLL"));
            //构造函数注入
            //builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //属性注入
            builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired(); // 这样支持属性注入

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            #endregion

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private static void SetupResolveRules(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("BLL"))
                .AsImplementedInterfaces();
        }
    }
}
