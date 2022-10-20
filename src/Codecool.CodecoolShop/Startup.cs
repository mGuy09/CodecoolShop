using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codecool.CodecoolShop.Daos;
using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Codecool.CodecoolShop
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
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Product/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=Index}/{id?}");
            });

            SetupInMemoryDatabases();
        }

        private void SetupInMemoryDatabases()
        {
            IProductDao productDataStore = ProductDaoMemory.GetInstance();
            IProductCategoryDao productCategoryDataStore = ProductCategoryDaoMemory.GetInstance();
            ISupplierDao supplierDataStore = SupplierDaoMemory.GetInstance();

            Supplier amazon = new Supplier{Name = "Amazon", Description = "New supplier of plants and fungi"};
            supplierDataStore.Add(amazon);
            Supplier lenovo = new Supplier{Name = "Lenovo", Description = "New merchandise from a hardware company"};
            supplierDataStore.Add(lenovo);
            ProductCategory poison = new ProductCategory {Name = "poison", Department = "Fungi and Moss", Description = "Is any member of the group of eukaryotic organisms that includes microorganisms such as yeasts and molds, as well as the more familiar mushrooms." };
            ProductCategory magic = new ProductCategory {Name = "magic", Department = "Magic Mush", Description = "Mushrooms" };
            productCategoryDataStore.Add(poison);
            productCategoryDataStore.Add(magic);
            productDataStore.Add(new Product { Name = "mushroom2", DefaultPrice = 49.9m, Currency = "USD", Description = "The easiest way to kill someone", ProductCategory = poison, Supplier = amazon });
            productDataStore.Add(new Product { Name = "magic-mushroom", DefaultPrice = 479.0m, Currency = "USD", Description = "These mushrooms will make you see unseen worlds.", ProductCategory = magic, Supplier = lenovo });
            productDataStore.Add(new Product { Name = "white-mushroom", DefaultPrice = 89.0m, Currency = "USD", Description = "Try one of these if you want to feel like flying. ", ProductCategory = magic, Supplier = amazon });

        }
    }
}
