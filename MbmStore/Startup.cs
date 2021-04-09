using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MbmStore.Models.ViewModels;
using Microsoft.AspNetCore.Http;

namespace MbmStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp)); 
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllersWithViews();
            services.AddMemoryCache(); 
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            app.UseSession();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "pagination", 
                    pattern: "Catalogue/Page{page}", 
                    defaults: new { Controller = "Catalogue", 
                        action = "Index" });
                endpoints.MapControllerRoute(
                    name: null, 
                    pattern: "Page{page:int}", 
                    defaults: new { controller = "Catalogue", action = "Index", productPage = 1 });
                endpoints.MapControllerRoute(
                    name: null, 
                    pattern: "Catalogue/{category}",
                    defaults: new { controller = "Catalogue", action = "Index", productPage = 1 });
                endpoints.MapControllerRoute(
                    name: null, pattern: "", 
                    defaults: new { controller = "Catalogue", action = "Index", productPage = 1 });
                endpoints.MapControllerRoute(
                    name: "pagination", 
                    pattern: "Catalogue/Page{page}", 
                    defaults: new { Controller = "Catalogue", 
                        action = "Index" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}


//We are going to store details of a user’s cart using session state,
//    which is data that is stored atthe serverand associated with a series of HTTP requests made by a user. 
//    ASP.NET provides a range of different ways tostore session state, including storing it in memory, which is the approach that we will use.
//    This hasthe advantage of simplicity, but it means that the session data is lost when the application is stopped orrestarted.
//    Enabling sessions requires adding services and middleware in the Startup class, as shownhere:



//URL ROUTING!
//The table describes the URL scheme that these routes represent. 
//    URLLeads to/CatalogueLists the first page of products from all categories/Catalogue/Page2Lists the specified page (in this case, page 2),
//    showing items from all categories/Catalogue/MusicShows the first page of items from a specific category (in this case, the Music category)
//    / Catalogue / Music / Page2Shows the specified page (in this case, page 2) of items from the specified category (in this case, Music)