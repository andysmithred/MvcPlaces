﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcPlaces.Models;

namespace MvcPlaces
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddRazorOptions(o =>
                {
                    o.ViewLocationFormats.Add("/Views/Shared/Partial/Common/{0}" + RazorViewEngine.ViewExtension);
                    o.ViewLocationFormats.Add("/Views/Shared/Partial/Lists/{0}" + RazorViewEngine.ViewExtension);
                    o.ViewLocationFormats.Add("/Views/Shared/Partial/Components/{0}" + RazorViewEngine.ViewExtension);
                });

            //var connection = @"Server=(localdb)\mssqllocaldb;Database=Travel;Trusted_Connection=True;ConnectRetryCount=0";
            //var connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Databases\Travel.mdf;Integrated Security=True;Connect Timeout=30";
            var connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\dev\MvcPlaces\MvcPlaces\Databases\Travel.mdf;Integrated Security=True;Connect Timeout=30";
            services.AddDbContext<TravelContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                //routes.MapRoute(
                //    name: "SharedPartialCommon",
                //    template: "~/Views/Shared/Partial/Common/{name}.cshtml");



            });
        }
    }
}
