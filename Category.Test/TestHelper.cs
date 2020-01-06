using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CategoryNUnit.Test
{
    class TestHelper 
    {
        //public static IConfigurationRoot GetIConfigurationRoot(string outputPath)
        //{
        //    return new ConfigurationBuilder()
        //       // .SetBasePath(outputPath)
        //       // .AddJsonFile("appsettings.json", optional: true)
        //       //.AddEnvironmentVariables()
        //       // .Build();
        //}

        public static ProductConfiguration GetApplicationConfiguration(string outputPath)
        {
            var configuration = new ProductConfiguration();

            //var iConfig = GetIConfigurationRoot(outputPath);

            //iConfig
            //    .GetSection("ProductMicroService")
            //    .Bind(configuration);

            return configuration;
        }




    }
}
