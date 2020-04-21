using AgendaOnline.MVC.AutoMapper;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;

namespace AgendaOnline.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AutoMapperConfig.RegisterMappings();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
