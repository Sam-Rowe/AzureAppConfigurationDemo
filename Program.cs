using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Identity;

namespace AppConfigDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                    webBuilder.ConfigureAppConfiguration(config =>
                    {
                        // If it is dev then use a connection string, otherwise use Azure Managed Identity to read the App Config.
                        if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") != null)
                        {
                            var settings = config.Build();
                            var connection = settings.GetConnectionString("AppConfig");
                            config.AddAzureAppConfiguration(options =>
                                options
                                .Connect(connection)
                                .Select(KeyFilter.Any, LabelFilter.Null)
                                .Select(KeyFilter.Any, Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"))
                                .UseFeatureFlags());
                        }
                        else
                        {
                        
                             var settings = config.Build();
                             config.AddAzureAppConfiguration(options =>
                                 options
                                    .Connect(new Uri(settings["AppConfig:Endpoint"]), new ManagedIdentityCredential())
                                    .Select(KeyFilter.Any, LabelFilter.Null)
                                    .Select(KeyFilter.Any, Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"))
                                    .UseFeatureFlags());
                        }
                    }).UseStartup<Startup>());
    }
}
