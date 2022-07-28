using FrackerHub.Entities;
using FrackerHub.Repositories;
using FrackerHub.Repositories.Implementation;
using FrackerHub.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrackerHub.Services.Configuration
{
    public class ConfigureRepositories
    {
        public static void AddServices(IServiceCollection services, IConfiguration configuration) // { get; set; }
        { 
            services.AddDbContext<AppDbContext>((options) =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("DbConnection"), 
                        sqlServerOptionsAction: sqlOptions =>
                            {
                                sqlOptions.EnableRetryOnFailure(); 
                            });
                });

            services.AddIdentity<User, Role>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            services.AddScoped<DbContext, AppDbContext>();

            services.AddTransient<IRepository<Item>, Repository<Item>>();
            services.AddTransient<IRepository<Category>, Repository<Category>>();
            services.AddTransient<IRepository<ItemType>, Repository<ItemType>>();
            services.AddTransient<IRepository<Asset>, Repository<Asset>>();
            services.AddTransient<IRepository<UserItem>, Repository<UserItem>>();


        }
    }
}
