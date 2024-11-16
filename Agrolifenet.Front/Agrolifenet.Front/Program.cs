using Agrolifenet.Front.Autenticacion;
using Agrolifenet.Front.Components;
using Agrolifenet.Infraestructura.Extenciones;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AgregarServiciosPersistencia(config);
builder.Services.AgregarServiciosDominio();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthorizationCore();
builder.Services.AddSingleton<PersonalizarAuthenticationService>();
builder.Services.AddSingleton<ProveedorAutenticacion>();
builder.Services.AddSingleton<AuthenticationStateProvider>(s => s.GetRequiredService<ProveedorAutenticacion>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
