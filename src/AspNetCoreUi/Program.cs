using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using AspNetCoreUi.Domain;
using AspNetCoreUi.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreUi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args)
                .Build();

            var scope = host
                .Services
                .CreateScope();

            DatabaseContext context = (DatabaseContext)scope
                .ServiceProvider
                .GetRequiredService<DatabaseContext>();

            DatabaseSeed seed = new DatabaseSeed();

            seed
                .SeedContext(context)
                .Wait();

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
