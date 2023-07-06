using System.Net;
using Material.Blazor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components.Web;
using System.Runtime.InteropServices.JavaScript;


namespace MockPortal_ClientSide
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            //builder.RootComponents.Add<HeadOutlet>("head::after");
            _ = builder.Services.AddMBServices();

            _ = builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
