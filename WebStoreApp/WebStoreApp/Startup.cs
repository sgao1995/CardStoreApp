﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;
using WebStoreApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace WebStoreApp
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot; //entry point to config data

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICardRepository, CardRepository>();
            services.AddTransient<IReviewRepository, ReviewRepository>();

            services.AddDbContext<AppDbContext>(options =>
                                        options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
              

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            DbSeeder.Seed(app);
            app.UseDeveloperExceptionPage();    

            app.UseStatusCodePages();         
            
            app.UseStaticFiles();

            app.UseMvc(config =>
            {
                config.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Catalogue" }
                    );
            });
        }
    }
}
