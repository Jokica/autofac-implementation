using System;
using Autofac;
using DemoLibrary;
using DemoLibrary.Utils;

namespace fac
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using(var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApp>();
                app.Run();
            }

            Console.ReadKey();
        }
    }
}
