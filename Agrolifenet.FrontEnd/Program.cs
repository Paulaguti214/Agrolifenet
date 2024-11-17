using Agrolifenet.FrontEnd;
using Agrolifenet.FrontEnd.Autenticacion;
using Agrolifenet.FrontEnd.Http;
using Agrolifenet.FrontEnd.Puerto;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7224") });

builder.Services.AddAuthorizationCore();
builder.Services.AddSingleton<PersonalizarAuthenticationService>();
builder.Services.AddSingleton<ProveedorAutenticacionJWT>();
builder.Services.AddSingleton<AuthenticationStateProvider, ProveedorAutenticacionJWT>(s => s.GetRequiredService<ProveedorAutenticacionJWT>());
builder.Services.AddSingleton<ILoginServicio, ProveedorAutenticacionJWT>(s => s.GetRequiredService<ProveedorAutenticacionJWT>());
builder.Services.AddScoped<IHttpConsumir, HttpConsumir>();
builder.Services.AddSweetAlert2();

await builder.Build().RunAsync();
