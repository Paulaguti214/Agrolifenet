using Agrolifenet.Infraestructura.Extenciones;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AgregarServiciosPersistencia(config);
builder.Services.AgregarServiciosDominio();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opciones =>
        opciones.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKeys = [new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetSection("Jwt:llave").Value!))],
            ClockSkew = TimeSpan.Zero
        });
builder.Services.AddCors(options =>
{
    options.AddPolicy("BlazorWAPolicy", policy =>
    {
        policy.WithOrigins("https://localhost:7136") // Cambia esto al dominio de tu aplicación Blazor
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.RoutePrefix = "swagger"; // serve the UI at root     
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1 Docs");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
// Usar la política de CORS
app.UseCors("BlazorWAPolicy");

app.Run();
