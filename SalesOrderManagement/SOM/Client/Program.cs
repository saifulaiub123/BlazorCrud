using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using SOM.Bll.IService;
using SOM.Bll.Service;
using SOM.Client;
using SOM.Core.Mapping;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<DialogService>();
//builder.Services.AddAutoMapper(typeof(ElementMapping).Assembly);
//builder.Services.AddScoped<IElementService, ElementService>();

await builder.Build().RunAsync();
