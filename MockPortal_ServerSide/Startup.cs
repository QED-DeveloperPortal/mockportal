using Material.Blazor;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Net.Http;

namespace MockPortal_ServerSide
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
            _ = services.AddRazorPages();
            _ = services.AddServerSideBlazor();
            _ = services.AddMBServices();
            //_ = services.AddControllersWithViews();
            _ = services.AddScoped((s) =>
            {
                var uriHelper = s.GetRequiredService<NavigationManager>();
                return new HttpClient
                {
                    BaseAddress = new Uri(uriHelper.BaseUri)
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                _ = app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                _ = app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                _ = app.UseHsts();
            }

            _ = app.UseHttpsRedirection();
            _ = app.UseStaticFiles("/mocks");
            app.UsePathBase("/mocks");
            _ = app.UseRouting();

            /*app.MapWhen(ctx => ctx.Request.Path.StartsWithSegments("/"), app1 =>
            {
                app1.UseBlazorFrameworkFiles("/");
                app1.UsePathBase("/");
                app1.UseStaticFiles();
                app1.UseRouting();
                app1.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                    endpoints.MapFallbackToFile("{*path:nonfile}", "mocks/index.html");
                });
            });*/

            app.MapWhen(ctx => ctx.Request.Path.StartsWithSegments("/mocks"), app1 =>
            {
                app1.UseHttpsRedirection();
                app1.UseBlazorFrameworkFiles("/mocks");
                app1.UsePathBase("/mocks");
                app1.UseStaticFiles("/mocks");
                app1.UseRouting();
                app1.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                    endpoints.MapFallbackToFile("mocks/{*path:nonfile}", "mocks/index.html");
                });
            });

            // _ = app.UseBlazorFrameworkFiles("");

            //_ = app.MapFallbackToFile("/index.html");

            _ = app.UseEndpoints(endpoints =>
            {
                //_ = endpoints.MapBlazorHub();
                //_ = endpoints.MapRazorPages();
                _ = endpoints.MapFallbackToPage("/_Host");
                //_ = endpoints.MapFallbackToFile("/index.html");
                
            });
        }
    }
}