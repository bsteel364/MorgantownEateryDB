using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MorgantownRestaurantsV2.Data;
using IronPython.Hosting;

namespace MorgantownRestaurantsV2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a file location from data");
            //string input = Console.ReadLine();

            var host = CreateWebHostBuilder(args).Build();
            //var python = Python.CreateEngine();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    //var context = services.GetRequiredService<ApplicationDbContext>();
                    //python.ExecuteFile("File Path for .py file execution");
                    DbInitializer.Initialize(services).Wait();
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occured creating the DB.");
                }
            }
            
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
