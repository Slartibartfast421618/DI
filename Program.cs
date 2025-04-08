using BlazoroOgDependencyInjection;
using BlazoroOgDependencyInjection.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Registrer HTTP client (allerede tilføjet af skabelonen)
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Registrer vores MessageService
builder.Services.AddSingleton<IMessageService, MessageService>();

await builder.Build().RunAsync();
