using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Demo.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //ConfigureContainer();
        }

        //public void ConfigureContainer()
        //{
        //    var container = new ServiceContainer();
        //    //container.Register<ICustomerService, CustomerService>();
        //    container.Register<IDataAccessObject<Customer>, CustomerRepository>();
            
        //    //container.Register<DatabaseContext>();
        //    //container.RegisterAssembly("Curative.DrugManager.BootStrapper.dll");
        //    container.EnableMvc();
        //    container.RegisterControllers();
        //    container.EnablePerWebRequestScope();
        //}
    }
}
