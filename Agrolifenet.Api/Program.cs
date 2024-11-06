using Agrolifenet.Infraestructura.Extenciones;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AgregarServiciosPersistencia(config);
builder.Services.AgregarServiciosDominio();

//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new() { Title = "Agro Life Net", Version = "v1" });

//    var xmlFilename = $"{typeof(Program).Assembly.GetName().Name}.xml";
//    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
   

//    c.CustomSchemaIds(type => type.ToString());

//});

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

app.Run();
