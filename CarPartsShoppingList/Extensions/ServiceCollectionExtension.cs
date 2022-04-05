using CarPartsShoppingList.Core.Contracts;
using CarPartsShoppingList.Core.Services;
using CarPartsShoppingList.Data;
using CarPartsShoppingList.Infrastructure.Data.Common;
using CarPartsShoppingList.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IApplicatioDbRepository, ApplicatioDbRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IEngineService, EngineService>();
            //services.AddScoped<ITransmisionService, TransmisionService>();
            //services.AddScoped<ISuspensionService, SuspensionService>();
            //services.AddScoped<IShoppingListService, ShoppingListService>();


            return services;
        }

        public static IServiceCollection AddApplicationDbContexts(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
    }
}