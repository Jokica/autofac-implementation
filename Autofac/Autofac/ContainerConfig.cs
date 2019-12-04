using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace fac
{
   public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
           
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                .Where(x => x.Namespace.Contains(nameof(DemoLibrary.Utils)))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I"+i.Name));
            builder.RegisterType<App>().As<IApp>();
            return builder.Build();
        }
    }
}
