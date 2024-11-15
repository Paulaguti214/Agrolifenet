using Agrolifenet.FrontEnd;
using Agrolifenet.FrontEnd.Autenticacion;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthorizationCore();
builder.Services.AddSingleton<PersonalizarAuthenticationService>();
builder.Services.AddSingleton<ProveedorAutenticacion>();
builder.Services.AddSingleton<AuthenticationStateProvider>(s => s.GetRequiredService<ProveedorAutenticacion>());

await builder.Build().RunAsync();
