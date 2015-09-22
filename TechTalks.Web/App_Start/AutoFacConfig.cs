using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using Autofac.Builder;
using Autofac.Features.Scanning;
using System.Reflection;
using TechTalks.BusinessLayer.Interface;

namespace TechTalks.Web
{
    public class AutoFacConfig
    {
        public static void RegisterAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            //builder.RegisterType(typeof(CustomerService)).AsImplementedInterfaces();
            //builder.RegisterType(typeof(CustomerRepository)).AsImplementedInterfaces();

             //builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
             //.Where(t => t.Name.EndsWith("BusinessLayer") || t.Name.EndsWith("DataAccessLayer"))
             //.AsImplementedInterfaces()
             //.InstancePerRequest();

            builder.RegisterAssemblyTypes(Assembly.Load("TechTalks.BusinessLayer")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(Assembly.Load("TechTalks.DataAccessLayer")).AsImplementedInterfaces();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}