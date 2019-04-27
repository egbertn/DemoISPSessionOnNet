using ispsession.io.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApplication5.Models;

namespace WebApplication5
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public override void Init()
        {
            this.PostAcquireRequestState += MvcApplication_PostAcquireRequestState;
            base.Init();
        }

        private void MvcApplication_PostAcquireRequestState(object sender, EventArgs e)
        {
            var application = (IApplicationCache)HttpContext.Current.Items["_ISPApplicationCache"];

            application["cachethis"] = new SomeViewClass { SomeString = "Highly Cachable stuff", someDate= DateTime.Now };
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
