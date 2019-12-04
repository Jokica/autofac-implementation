using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace fac
{
    public class App : IApp
    {
        private readonly IBusinessLogic business;

        public App(IBusinessLogic business)
        {
            this.business = business;
        }
        public void Run()
        {
            this.business.ProcessData();
        }
    }
}
