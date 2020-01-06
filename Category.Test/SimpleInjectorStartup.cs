using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;

namespace CategoryNUnit.Test
{
    public class SimpleInjectorStartup
    {
        public Container Container => new Container();

        public void Configure()
        {

           // Container.Register<ICategoryRepository, CategoryTest>();

        }
    }
}
