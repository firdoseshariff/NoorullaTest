using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Routing;
using PaymentBusinessLayer;
using RepositoryPayment;
using Microsoft.AspNetCore.Http;
using PaymentBusinessLayer.IPayment;
using PaymentBusinessLayer.Payment;
using PaymentBusinessLayer.OrderPay;

namespace PaymentGateWay
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
               }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors(options => options.AddPolicy("MyBlogPolicy", builder =>
            {
                builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            }));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(
                options =>
                {
                    var resolver = options.SerializerSettings.ContractResolver;
                    if (resolver != null)
                        (resolver as DefaultContractResolver).NamingStrategy = null;

                });
           services.AddDbContext<PaymentGateWayEntities>(Item => Item.UseSqlServer(Configuration.GetConnectionString("ConnectPay")));
            services.AddCors();
            services.AddScoped<IBookPayment, BookPayment>();
            services.AddScoped<IProductPayment,ProductPayment>();
            services.AddScoped<ILearning, Learning>();
            services.AddScoped<IAddOrUpgradeUser, AddOrUpgradeUser>();
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
                app.UseHsts();
            }
            app.UseCors(options =>
            {
                options.WithOrigins("http://localhost:4200")
                .AllowAnyMethod()
            .AllowAnyHeader();

            });
            app.UseMvc();
            app.UseHttpsRedirection();
            app.UseMvc(routes =>
            {
                routes.MapRoute(

                    name: "Default",
                    template: "{controller=home},{action=Index},/{id?}");

            });


        }
    }
    }

