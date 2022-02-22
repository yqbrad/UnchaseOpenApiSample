using BlazorTemplate;
using BlazorTemplate.OpenAPIService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp
    => new HttpClient
    {
        BaseAddress = new Uri("http://localhost:3070/")
    });

builder.Services.AddScoped<IPeopleService,PeopleService>();

await builder.Build().RunAsync();