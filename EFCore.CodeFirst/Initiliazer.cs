using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst
{
    public class Initiliazer
    {
        public static IConfigurationRoot configuration;

        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(
                "appsettings.json", optional: true, reloadOnChange: true);
            configuration = builder.Build();
        }
    }
}
