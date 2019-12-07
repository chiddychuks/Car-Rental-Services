using CarRental.Web.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Web.Extensions
{
    public static class DatabaseExtensions
    {
        public static IWebHost MigrateDb(this IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    context.Database.Migrate();
                }
                catch (Exception ex)
                {
                    var logger = host.Services.GetRequiredService<ILogger<ApplicationDbContext>>();
                    logger.LogError(ex, "An error occurred migrating the the DB.");
                }
            }
            return host;
        }
    }
}
