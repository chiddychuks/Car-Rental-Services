using CarRental.Core.Interface.Repositories;
using CarRental.Core.Interface.Services;
using CarRental.Core.Services;
using CarRental.Infrastructure.Repositories;
using CarRental.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Web.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddAppServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<DbContext, ApplicationDbContext>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOwnerService, OwnerService>();
            services.AddScoped<IOwnerRepository, OwnerRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
        }
    }
}
