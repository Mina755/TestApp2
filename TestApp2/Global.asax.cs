using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.Owin.Builder;

namespace TestApp2
{
    public class Global : HttpApplication
    {
        public class OwinStartup
        {
            public void Configuration(IAppBuilder appBuilder)
            {
                // Настройка конвейера обработки запросов OWIN
            }
        }
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            OwinStartup owinStartup = new OwinStartup();

            owinStartup.Configuration(appBuilder: new AppBuilder());

            // настройка маршрутов
            //RouteConfig.RegisterRoutes(RouteTable.Routes);

            // настройка SignalR
            //var hubConfiguration = new HubConfiguration();
            //hubConfiguration.EnableDetailedErrors = true;
            //var resolver = new DefaultDependencyResolver();
            //resolver.Register(typeof(IUserIdProvider), () => new CustomUserIdProvider());
            //hubConfiguration.Resolver = resolver;
            //app.MapSignalR(hubConfiguration);

        }
    }
}