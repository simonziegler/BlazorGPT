using Material.Blazor;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using BlazorGPT.Lib;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMBServices();

await builder.Build().RunAsync();
